# 🎮 ICT 3종 게임 프로젝트

**제작자**: 권민환(2019265006), 윤대영(2019265086)  
**개발환경**: Windows 10 / C# / Unity / Visual Studio

---

## 🧠 Motivation - 개발 동기

C# 프로젝트 수업을 통해 Unity를 직접 경험하고, 나만의 게임 세계를 구현해보고자 이 프로젝트를 기획하게 되었습니다.  
Unity를 활용한 게임 개발과 C# 프로그래밍 역량을 함께 키우는 것이 목표였습니다.

---

## 🔍 프로젝트 개요

- **개발 도구**: Unity (각 게임 제작), Visual Studio (윈도우 폼 통합)
- **플랫폼**: Windows Desktop
- **기능 요소**:
  - 개별 게임 3종 제작 및 실행
  - 통합 런처(윈도우 폼)를 통한 실행 UI 제공
  - 사용자 기록 관리(DB 연동 예정)

---

## 🧩 프로젝트 구성 요소

### 1. 🕹 Platformer Game

- 2D 횡스크롤 형식
- 플레이어 이동, 점프, 적과 충돌 처리
- 기본 스크립트:
  - `Player.cs` : 이동 및 점프 제어
  - `Enemy.cs` : 적 행동 처리
  - `Game.cs` : 게임 진행 로직
- 마리오와 유사한 구성

---

### 2. 🔢 Sliding Puzzle Game

- 1~15 숫자 퍼즐 (빈 칸 1개 존재)
- 스크립트 구성:
  - `Board.cs` : 전체 판 관리
  - `Tile.cs` : 타일 개별 이동 처리
  - `UIController.cs` : 시간/이동수 출력 및 UI 관리
- 게임 시작 시 숫자 랜덤 배치
- 게임 종료 시 기록 출력 (시간, 이동 수, 재시작 버튼 등)

---

### 3. 🧗 Infinity Stairs

- 좌클릭: 계단 이동 / 우클릭: 방향 전환
- 실패 시 현재 점수, 최고 점수, 재시작 UI 출력
- 스크립트 구성:
  - `Player.cs` : 캐릭터 이동 및 충돌 처리
  - `GameManager.cs` : 게임 시작/종료 관리

---

### 4. 🧱 프로젝트 통합 (윈도우 폼)

- C# Windows Forms 애플리케이션으로 3종 게임 실행 UI 구현
- 사용자 버튼 클릭 시 각 게임 실행
- DB 연동을 통해 사용자 점수 및 기록 관리 (계획 중)
- Unity DB ↔ VS 폼 DB 연동 방식 고려

---

## 📆 개발 일정 요약

| 항목 | 권민환 | 윤대영 |
|------|--------|--------|
| 게임 기획 및 UI | O | O |
| Platformer 개발 | O |  |
| Sliding Puzzle 개발 |  | O |
| Infinity Stairs 개발 | 공동 작업 |
| 통합 폼 구현 | O | O |
| 발표 자료 작성 | O | O |

---

## 📂 폴더 구조 예시

```
ICT-3Games/
├── Platformer/
│   ├── Assets/
│   └── Scripts/
├── SlidingPuzzleGame/
│   ├── Assets/
│   └── Scripts/
├── InfinityStairs/
│   ├── Assets/
│   └── Scripts/
├── Final_Project/
│   ├── Final_Project.sln
│   └── WinForms UI (게임 런처)
└── README.md
```

---

## 💡 향후 계획

- Unity 내 데이터 기록 기능 추가
- DB 연동을 통한 점수 및 사용자 정보 저장
- 각 게임별 랭킹 시스템 구현 (선택 사항)

---

## 🙏 감사 인사

프로젝트를 통해 Unity와 C# 모두를 경험해볼 수 있는 소중한 시간이었습니다.  
서로의 게임을 합쳐 하나의 애플리케이션으로 구성하며 팀워크와 개발 협업 능력도 향상되었습니다.

---

## 📊 발표자료

> `권민환윤대영 c# 최종발표.pptx` 파일 참고
