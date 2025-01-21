# TPMS_DTC

**TPMS_DTC**는 PCAN(PEAK) 디바이스를 통해 CAN 통신을 수행하고,  
차량 TPMS 관련 진단/프로그래밍 기능을 간단한 WinForms GUI로 테스트할 수 있도록 하는 예시 프로젝트입니다.

## 작동 영상
![Image](https://github.com/user-attachments/assets/49278022-9c83-4698-ae48-4840823ac2f9)

## 주요 기능

1. **CAN 채널 연결/해제**  
   - CH1(PCAN-USB Channel 1) 연결  
   - 연결 성공 시 메시지 알림 및 수신 타이머 시작

2. **CAN 메시지 수신/송신**  
   - **수신**:  
     - 10ms마다 `System.Threading.Timer`를 통해 최대 100개의 메시지를 읽어들임  
     - 특정 ID(예: `0x7DE`)나 프레임 형식(FF, CF, FC 등)에 따라 처리 로직 분기  
     - MultiFrame(ISO-TP) 로직 일부 구현 (FF 수신 후 FlowControl 자동 송신, etc.)  
   - **송신**:  
     - 단일 프레임(`Single Frame`) 또는 멀티프레임(FF, CF) 방식 지원  
     - Flow Control(FC) 메시지도 설정 가능 (Stmin, BS 등)

3. **로그 관리**  
   - **ListBox**에 TX/RX 로그를 표시  
   - 500ms마다 큐에 쌓인 로그를 파일(TxLog, RxLog, AllLog)로 저장  
   - 특정 ID(예: `0x7DE`)만 화면에 표시하도록 필터링  
   - GUI에서 “Log Reset” 버튼을 통해 ListBox 항목 초기화 가능

4. **데이터 파싱**  
   - Read / Write 명령어(예: `Read VIN`, `Read DTC`, etc.)에 따라 받은 바이트 배열을 파싱  
   - VIN, DTC(Active/Historic), ManufacturerPart, SensorID 등등을 해석하고 LogListBox에 추가 설명 표시

5. **Flow Control 및 MultiFrame**  
   - FF(First Frame)를 수신하면 자동으로 FC(FlowControl) 송신 (ECU 측의 블록 사이즈/간격 제어는 생략 또는 소프트웨어 적용)  
   - 여러 CF(Consecutive Frame)를 합쳐서 하나의 완성된 데이터로 취급  
   - 수신 완료 후 파싱 진행

6. **UI 스크롤 및 스레드 안전성**  
   - UI 변경(로그 추가, 스크롤 이동) 시 `InvokeRequired / Invoke(...)`로 스레드 안전성 보장  
   - 수신은 별도 `Timer` 콜백에서 수행, ListBox에 로그 추가 시 반드시 Invoke 사용

7. **명령어 즐겨찾기(TreeView)**  
   - 특정 노드를 더블클릭하면 미리 정의된 바이트 배열을 TX로 전송 (예: `StartDiagnostic(0x10 81)`, `Read VIN(0x1A 90)`, 등)  
   - 일부 명령어는 하위 창(예: WriteVIN, WriteHMC)에서 입력받아 전송 가능

---

## 디렉토리 구조

예시(일부 가정)입니다:

```
TPMS_DTC
├─ TPMS.cs           // 메인 Form 코드
├─ TPMS.Designer.cs  // Form 디자인 파일(자동 생성)
├─ WriteVIN.cs       // VIN 입력 서브 폼
├─ WriteHMC.cs       // HMC/KMC 설정 서브 폼
├─ ...
├─ LOG/              // 로그 파일 저장 디렉토리(프로그램 내부에서 지정)
├─ ...
└─ README.md         // 본 설명 파일
```

---

## 주요 클래스/메서드 설명

- **`TPMS`**: WinForms `Form` 클래스
  - `CH1_Button_Click`  
    - PCAN 채널 연결/해제 버튼 핸들러  
    - 연결 시 `StartTimersIfNeeded()`, 해제 시 `StopTimersIfNoConnection()`
  - `StartTimersIfNeeded`, `StopTimersIfNoConnection`  
    - CH1 연결 상태에 따라 수신용 `System.Threading.Timer` 및 로그 저장용 `WinForms Timer`를 시작/중지
  - `CanReadTimer_Tick`  
    - 10ms 간격으로 호출 → `ReadFromChannel(...)`에서 최대 100개 메시지 읽음
  - `ReadFromChannel(TPCANHandle)`  
    - PCANBasic.Read → 메시지 파싱  
    - FF/CF/FC/에러 코드 구분하여 로그 저장 및 후처리(`ProcessRxData`, `SendFlowControl`, etc.)
  - `ProcessRxData` / `ParseRxData`  
    - ISO-TP 멀티프레임 데이터를 병합 후, VIN/Manufacturer 등 파싱
  - `MessageSendButton_Click`  
    - 사용자가 수동으로 입력한 8바이트(또는 명령어)를 CAN 송신  
  - `SendCanCommand`  
    - TreeView 명령어 더블클릭 시 호출되는 전송 함수  
    - 7바이트 이하 → Single Frame / 그 이상 → First/Consecutive Frame
  - `UpdateDisplay` / `AddLogToListBox`  
    - UI 스레드에서 ListBox를 업데이트하는 로직  
  - `LogAdditionalDescription` 계열  
    - Read Info, DTC Info, Error Info 등 메시지 별도의 파싱·로그를 추가하는 헬퍼 메서드

- **`WriteVIN`, `WriteHMC`, `WriteVehicle`** 등 서브 폼  
  - 각 폼에서 특정 데이터(예: VIN 17자리, HMC/KMC 설정 값)를 입력받아 바이트 배열로 구성 → `SendCanCommand` 전송

---

## 빌드 및 실행

1. **Visual Studio**(또는 적절한 .NET 개발 환경)에서 솔루션/프로젝트를 연다.
2. **NuGet** 패키지나 **PCANBasic.dll** 참조가 필요할 수 있음(PCAN-USB 사용 시).
3. **빌드**(`Ctrl + Shift + B`) 후 **실행**(`F5`).
4. 프로그램 GUI에서 **CH1 버튼**으로 PCAN 채널 연결.
5. 연결 성공 후, **MessageSendButton** 또는 **TreeView 명령어**를 통해 CAN 메시지 송·수신 테스트.

---

## 로그 파일 구조

- **기본 저장 경로**: `C:\Users\...\LOG` (코드 상 `folderPath`로 지정)  
- **파일**:  
  - `TxLog2.txt` : TX 메시지만 기록  
  - `RxLog2.txt` : RX 메시지만 기록  
  - `AllLog2.txt` : 모든 메시지 (TX & RX)  
- 10ms 주기의 WinForms `saveLogTimer`에서 500ms마다 큐(`logQueue`)를 한꺼번에 비우며 파일에 기록

---

## 주의/제한 사항

1. **ISO-TP 완전 구현 아님**  
   - Block Size, STmin 세부 로직은 ECU 측 FlowControl을 제어하지 않거나 간소화  
   - 대용량 데이터를 송·수신할 때 일부 제한 가능
2. **PCANBasic.dll 요구**  
   - PEAK-Systems 하드웨어 드라이버 & PCANBasic API 설치 필요  
   - `using Peak.Can.Basic;` 참조해야 정상 동작
3. **UI Freeze/교착**  
   - 대량 메시지 또는 느린 PC 사양에서, 무한루프 대신 “한 번에 100개”만 읽도록 조정  
   - MessageBox(모달) 호출 시 Invoke 처리가 되어 있으므로 교착 상태에 주의
4. **추가 파라미터**  
   - Flow Control의 BS, STmin, Dud_STmin_us 등은 UI에서 설정 가능

---