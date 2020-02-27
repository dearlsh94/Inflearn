# 14일만에 배우는 C#닷넷코어

- Inflearn - SEJONG IT EDU
- 33,000 KRW
- 수료증 발급
- 9시간 50분 (590분)



## 특징

- 패턴 프로그래밍에 최적화
- 테스트, 유지보수가 쉬워야 함.
- MVC 패턴 사용
- 의존성 주입 패턴 사용



## MVC 패턴

- End User : Request to Controller
- Controller : Response to End User
- View : Display Response
- Model(ViewModel) : move flow, End User to Controller to View



## 의존성주입 패턴

- Services 프로젝트 구성
  - 서비스 재사용성
  - 모듈화



## Entity Framework Core (EF Core)

- Code-First 방식 : 코드작성 우선주의
  - Migrations : 미리 작성 된 코드로 Database 테이블, 컬럼 생성
- Database-First 방식 : Database 작업 우선 주의
  - 이미 생성 된 Database 테이블과 컬럼 C#에서 사용
  - Entity Data Modelling : 코드를 손쉽게 작성할 수 있도록 도와줌.
- Lambda, FromSql, ExecuteSqlCommand 메소드 제공



### Code-First 방식

- Fluent API
  - DbContext를 상속받는 Class를 생성하여 DB작업 구현
    - 생성자 상속
    - DB 테이블 리스트 지정
    - 부모 클래스의 onModelCreating virtual 메소드를 상속받아 구현
  - Migrations 커맨드 이용
    - Migration 시 지정하는 이름이 일종의 스냅샷
- 되도록 DBMS에서 작업하기 보다는, Migrations 를 통해 수정하여야 한다.
  - 정합성 유지
- Migrations 를 통한 이력관리 가능



### Database-First 방식

- Entity Data Modelling 을 사용하여 편리함.
- Database 작업의 이력관리 불가
- Table 또는 Column 변경 시 C#코드도 수동으로 변경해야 함.



### FromSql 메소드

- SQL QueryString 을 통한 데이터 조회
  - table, view, function, stored procedure ...



## Data Protection

- 암호화 알고리즘을 적용한 키관리를 통해 데이터 보호

- Extension Library 설치
  - Extension.DependencyInjection
  - AspNetCore.DataProtection

- GUID xml 파일에 key id, version, 키 생성일, 키 활성화일자, 키 만료일자, 암호화 유형, 암호 알고리즘 유형, 암호키 길이, 해시알고리즘 유형 등의 정보 존재