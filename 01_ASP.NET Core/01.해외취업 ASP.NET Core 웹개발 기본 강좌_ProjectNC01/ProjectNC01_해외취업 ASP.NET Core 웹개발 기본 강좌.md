# 해외취업 ASP.NET Core 웹개발 기본 강좌

- Inflearn - SEJONG IT EDU
- 33,000 KRW
- 수료증 발급
- 4시간 2분(242분) (35회)

## 장점

- 뛰어난 접근성
- 오픈 소스
- 탄탄한 라이브러리와 좋은 패턴
- Visual Studio IDE
- Cross-Platform
- 현대적 프로그래밍 언어
  - async, webpack, Restful API 등등... 



## 셋업

- [.NET Core SDK 설치](https://www.microsoft.com/net)
  - CMD에서 설치 테스트 ```$dotnet```

- Visual Studio 또는 Visual Studio Code 설치
  - 강의는 VS로 진행하지만, VS Code 환경에서 실습할 것임. (더 가벼운 환경이라)
- [VS code 에서 C# 플러그인 설치](https://docs.microsoft.com/ko-kr/dotnet/core/tutorials/with-visual-studio-code)
  - Extension - C# 검색 - C# for Visual Studio Code 설치

- [VS code 에서 .NET Core 다루기](https://code.visualstudio.com/docs/languages/dotnet)



## 프로젝트 생성

- ```
  $ cd [Project Path]
  $ dotnet new [mvc | console]
  $ dotnet run
  ```

  - "Required assets to build and debug ar missing. Add them?" -> Yes



## MVC 란

- Model - View - Controller

### Model (.cs)

- 데이터를 다룸.
- 실질적 기능.
- DB와 연결
- Controller 와 송수신

### Controller (.cs)

- Web Request
- View와 Model 연결
- Model, View 와 송수신
- 네이밍 : 파일명 뒤에 Controller 접미사 붙이기

### View (.cshtml)

- 사용자에게 실제 보여지는 부분.

- Web Rendering
- Controller 와 송수신



## MVC 매핑 구조

1. `/Controllers` 내부에 ~Controller 접미사를 붙인 C# Controller 생성 (.cs)

2. `/Views` 내부에 Controller 이름의 폴더 생성

3. `/Views/[ControllerName]` 내부 Controller에서 IActionResult를 리턴하는 함수명과 동일한 이름의 Razor View 파일 생성 (.cshtml)



## 유효성 검사

- `asp-validation-for` 속성 사용
  - `/Views/_ViewImports.cshtml` 파일에 TagHelper 설정

    ```
    @using ProjectNC01
    @using ProjectNC01.Models
    @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
    ```

    - `/Views` 내부 Razor View 파일에서 asp-validation-for 등 TagHelper를 사용할 수 있도록 설정

- Model 클래스에 선언 된 Property에 유효 조건을 설정한다.
  - `[Required]` : 필수 입력
  - `[MaxLength(50)]` : 50 자 이내 입력
  - `[MinLength(5)]` : 5자 이상 입력
  - `[BindNever]` : Post 전송 시 해당 데이터 바인딩 제외
  - 등등...
- POST 전송 데이터 Token 비교
  - POST 방식은 Client > Server 데이터 송신 시 Token 값을 보낸다.
    - Token 값을 사용하지 않기 위해서는 form 태그에 `asp-antiforgery="false"` 속성을 선언한다.
  - Server에서는 해당 Token 값을 검사하여 Client가 보낸 데이터가 맞는 지 확인한다.
  - Controller 에 선언된 `[HttpPost]` 하단 `[ValidateAntiForgeryToken]` 설정
  - 보안을 위해 POST에는 항상 사용하기를 권장



## View Model

- 여러 Model을 한 View에 보여질 수 있게 한다.
- `/ViewModel` 내부 ViewModel 파일 생성
- ViewModel Class 내부 Property로 Model 선언
- View에서 ViewModel을 사용하였으면, Controller에서도 동일한 ViewModel 로 사용한다.





## Layout

- Web Site 어느 곳에서나 동일하게 보여지는 마스터 뷰

- Navigation bar, Header, Footer 등등

- `/views/shared` 경로에 생성 된 `_Layout.cshtml` 파일에 구현

- css, js 등 파일 import

- View Page 에 해당 Layout 을 사용하겠다는 선언 필요

  ```c#
  @{
  	Layout = "_Layout";
  }
  ```

- Razor는 최초 실행 시 `/Views/_ViewStart.cshtml` 파일이 존재하는 지 검사하며, 존재 할 시 해당 파일 자동으로 모든 페이지에 import 하여 준다.







## Error

- error CS0103: model로' 이름이 현재 컨텍스트에 없습니다.
  - @using 지시문으로 참조하는 model의 namespace 경로 또는 이름이 잘못되어 발생.
  - HTML 주석 내부에 @model 키워드 사용 시 해당 구문 읽어서 에러 발생.