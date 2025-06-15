# iot-webapp-2025

<p>IoT 개발자 과정 <a href="https://dotnet.microsoft.com/ko-kr/apps/aspnet" target="_blank" style="color:red;">ASP.NET Core</a> 학습 리포지토리</p>

## 1일차

### Web
- 인터넷 상에 사용되는 서비스 중 하나
- 웹을 표현하는 기술 : HTML(Hyper Text Markup Language). XML(eXtensable Markup Language)의 경량화 버전
- 2014년 이후 HTML5로 적용되고 있음

#### 웹 기술
- 웹 표준기술(프론트엔드) : HTML 5(웹 페이지 구조) + CSS 3(디자인) + JavaScript (인터렉티브)
- 웹 `서버`기술(백엔드) : ASP.NET Core(C#|VB), SpringBoot(Java), Flask|dJango(Python), CGI(PHP,C), Ruby, ...
- 웹 서비스 : 프론트엔드 + 백엔드
- 웹 브라우저 상에서 동작 : 현재는 웹 브라우저 상에서만 동작하는 경계가 사라졌음 

#### HTML 5
- 웹 페이지를 구성하는 언어(근간, 기본)
- HTML 상에서도 디자인을 할 수 있으나, 현재는 CSS로 분리

#### CSS 3
- Cascading Style Sheet : 객체지향에 사용되는 부모자식관계로 디자인 하는 기술
- 아주 쉬운 문법으로 구성됨

#### JavaScript 
- 표준명 ECMAScript 2024.
- Java와 전혀 관계없음. Java의 문법을 차용해서 사용한 웹 스크립트 언어
- 엄청난 발전을 이뤄 여러가지 기술로 분리
    - React.js, View.js 등의 프론트엔드 기술 언어로 분파
    - Node.js와 같은 웹 서버기술에도 적용
    - VS Code(아톰에디터 기반) 같은 개발도구를 만드는데도 사용
    - 3D 게임, 모바일 개발 등 다양한 분야에 사용

#### 웹 서버기술
- `ASP.NET Core` : C#/VB언어도 웹 서버를 개발
- SpringBoot, Flask 등 다른 언어로 웹 서버를 개발해도 무방

#### 왜 웹을 공부해야하나?
- 스마트팩토리 솔루션을 대부분 웹으로 개발(사용범위 제약을 없애기 위해서)
    - 웹 사이트, 일부분 모바일 앱 동시 개발
- 스마트홈(IoT), ERP, 병원예약, 호텔예약, 인터넷뱅킹, 온라인서점 ... 
- 모든 IT/ICT 개발에 웹 기술은 포함되어 있음

#### HTTP
- HyterText Transfer Protocol
- 웹을 요청/응답하는 프로토콜
- HTTPs : HTTP with secure. 보안을 강화한 HTTP 프로토콜

### 웹 표준기술 - HTML

#### VS Code 확장설치
- Live Server

#### HTML 구조
- [소스](./day01/html01.html)
- html 태그 내에 head, body로 구성(무조건!)
- README.md에도 HTML 태그를 그대로 사용가능(heading은 적용안됨)
- VS Code에서 html:5 자동생성
- [소스](./day01/html02.html), [소스](./day01/html03.html)
- CSS가 소스라인을 많이 사용. css는 외부스타일로 분리 사용
- JS도 소스라인이 매우 김. JS도 외부스크립트로 분리 사용
- 웹 브라우저의 개발자모드(F12)로 디버깅을 하는 것이 일반적

#### HTML 기본태그(body에 사용)
- [소스](./day01/html04.html)
- h1 ~ h6 : 제목글자
- p, br, hr : 본문, 한줄내려가기, 가로줄
- a : 링크
- b/strong, i, small, sub, sup, ins/u, del : 굵은체, 이탤릭체, 작은글씨, 아래첨자, 위첨자...
- ul/ol, li : 동그라미목록/순번목록, 목록아이템
- table, tr, th, td : 테이블, 테이블로, 테이블헤더, 테이블컬럼
- img, audio, video : 이미지, 오디오, 비디오 
- [소스](./day01/html05.html), [소스](./day01/html06.html)
- form, input, button, select, textarea, label : 입력양식, 텍스트박스, 버튼, 콤보박스, 여러줄텍스트박스, 라벨
    - form action에 `get`과 `post`. (dialog는 무시)
- progress : 진행률
- div, span : 공간분할

#### 공간분할태그
- [소스](./day01/html07.html)
- div 사용 이전엔 table, tr, td로 화면 분할을 활용
- table을 여러번 중복하면 렌더링속도 저하로 화면이 빨리 표시가 안됨
- 웹 기술표준을 적용해서 div 태그로 공간분할을 시작
- div를 CSS로 디자인 적용해서 렌더링속도를 빠르게 변경
- 게시판 목록, 상세보기 등에서는 아직도 table을 사용 중

#### 시맨틱웹
- 웹구조를 좀더 구조적으로 세밀하게 구분짓는 의미로 만들어진 웹 구성방식
- 시맨틱 태그
    - header, nav, main, section, aside, article, footer 등
    - 기본 HTML 태그가 아니고, 필수도 아님
- 최근에는 잘 사용안함. div태그에 id로 부여해서 유사하게 사용 중
- div만 잘 쓰면 됨

### 웹 표준기술 - CSS

#### 개요
- 마크업 언어에 표시방법을 기술하는 종속형 시트(계단식 스타일시트)
- WPF는 CSS와 유사한 방식을 차용
- 문법
    ```css
    태그/아이디/클래스 {
        /* key: value를 반복*/
        key: value; /* C++ 주석 // 한줄 주석은 안됨 */
    }
    ```
- html 태그 속성
    - id : 웹페이지 하나당 한번만 쓸것
    - class : 여러번, 여러개 사용가능

- UI기술로 많은 분야에서 사용
    - Qt, PyQt, Electron, Flutter(모바일), React Native(모바일), React.js, ...
- [소스](./day01/html08.html)

## 2일차

### 웹 표준기술 - CSS
- HTML, CSS, JS 동일하게 "(쌍따옴표), '(홑따옴표) 동시 사용가능
- Python은 ''를 추천, 웹은 ""를 추천
- 스타일부터 레이아웃까지 연습
- [소스](./day02/html04.html)

### 웹 표준기술 - JavaScript
- Java(컴파일러언어)와 아무런 관계없음
- JavaScript(스크립트언어)
- [소스](./day02/html05.html)

#### 기본문법
- HTML내에 script 태그 내에 작성
- 변수 선언이 var(전역,지역), let(지역)
- 문장 끝에 ; 생략이 가능하지만 되도록 사용할 것
- 키워드

    <img src="./image/web0001.png" width="600">

- 화면메시지박스 : alert()
- 디버깅 출력 : console.log()

    ```js
    <script>
        // 변수 선언
        var radius = 10;
        var PI = 3.14159265;

        // 출력
        alert(2 * radius * PI);
        console.log(2 * radius * PI);
        // 개발자도구 > 소스에서 디버깅가능
        // VisualStudio와 동일
    </script>    
    ```
- 변수타입 : 숫자, 문자열, 불린, ... 
    - null : undefined
- 연산자 : 비교연산자, 수식연산자, 논리연산자, ...
    - 차이점 : === (타입과 값이 완전일치)
- 흐름제어 : if, for, while 
- 함수 : function 함수명
    - 익명함수 function() {}
- 거의 대부분 C문법과 동일

#### JavaScript 객체
- [소스](./day02/html06.html)
- JSON : 자바스크립트 객체를 표현하는 방식
- 매우 편리하여 표준으로 지정하고 모든 IT분야에서 사용 중

    ```js
    var json_data = {
        key1: value1,
        key2: value2,
        method: function() {
            // ...
        },
    }
    ```

#### DOM
- [소스](./day02/html07.html)
- Document Object Model : HTML 문서의 구조를 JS에서 접근할 수 있는 개념
- HTML 태그를 JS로 조작한다는 의미
- JS에서 가장 중요한 부분 - 전통적인 JS 처리방식(구닥다리)
- DOM에서 쓰이는 주요 함수들

    ```js
    // 1개 선택
    document.querySelector(선택자);
    document.getElementById(아이디);
    // 다중 선택
    document.querySelectorAll(선택자); // for문으로 후처리
    document.getElementsByName(이름);
    document.getElementsByClassName(클래스);

    // 객체변수
    var obj = document.getElementById("container");
    obj.style.backgroundColor = 'red';
    obj.style.color = 'blue';
    obj.innerHTML = "변경 문자열";
    obj.getAttribute("속성");
    obj.setAttribute("속성", 변경할값);

    window.onload = function(event) {
        // ...
    }
    ```

#### jQuery
- JavaScript DOM의 복잡한 사용법을 개선하고 만든 라이브러리
- 2006년도 개발, 2023년까지 업데이트
- https://jquery.com/
- CDN 방식으로 사용
    ```html
    <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
    ```
- 모든 DOM 객체에 접근할때 `$(선택자|아이디|클래스)` 로 처리
- jQuery on('이벤트', function() {}) 또는 이벤트(function () {})

    <img src="./image/web0002.png" width="600">

- [소스](./day02/html09.html)

#### Vanilla JS
- 순수 JS로 불리며 jQuery처럼 CDN링크가 필요없음
- 전통적 방식보다 효율적으로 변경됨
- 새로 개발되는 웹사이트는 Vanilla JS를 사용

## 3일차

### 반응형웹
- UTF-8 적용 전 : 한국어웹, 영어웹, 일본어웹 등 웹페이지를 언어별로 개발필요
- 반응형 웹 이전 : PC용, 모바일용, 태블릿용 등 웹사이트 다중 개발필요
- 문제 : 하나의 웹페이지가 수정되면 다른 웹페이지들도 다 수정 -> 시간, 돈의 Loss
- 하나의 웹페이지로 기기, 언어문제를 전부 해결하고자 나온 기술중 화면쪽 -> 반응협웹
- `Responsive Web` : 웹, 모바일 등의 기기와 해상도에 상관없이 하나의 웹으로 모두 표현할 수 있는 웹화면 개발 기술

- HTML5에 반응형 웹 메타태그만 사용

    ```html
    <!DOCTYPE html>
    ...
    <head>
    <!-- 반응형웹 중요태그 -->
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    ```

- 부트스트랩으로 학습
- https://inpa.tistory.com/category/Style%20Sheet/Bootstrap5?page=2 

### 부트스트랩
- 현재 전세계적으로 가장 많이 사용되는 오픈소스 CSS, JS 프레임워크
- 트위터 블루프린트로 시작. 트위터 웹사이트를 꾸미기위해서 개발시작
- 현재 5.3 버전
- 이전에는 jQuery 사용했으나 현재는 Pure JS로 전향되었음
- [공식사이트](https://getbootstrap.com/)

#### 부트스트랩 시작
- [시작](https://getbootstrap.com/docs/5.3/getting-started/introduction/)
- GetStarted에 나와있는 CSS와 JS를 웹페이지에 붙여넣기

    <img src="./image/web0003.png" width="600">

#### 부트스트랩 학습
- 버튼 사용법

    <img src="./image/web0004.png" width="600">

- 미디어쿼리 : 웹페이지 사이즈에 따른 사용법을 위해 필요
    - Bootstrap에서 sm, md, lg 등의 infix를 사용할 경우가 많음  
    - X-Small : None(사용할 이름없음) (< 576px)
    - Small : sm (>= 576px)
    - Medium : md (>= 768px)
    - Large : lg (>= 992px)
    - Extra large : xl (>= 1200px)
    - Extra extra large : xxl (>= 1400px)

- 컨테이너 : 기본 레이아웃에서 가장 중요! 그리드 스타일이라고 부름
    - container - 일반적인 넓이사용. 양쪽에 여백이 존재
    - container-fluid - 여백없이 웹페이지를 꽉채우는 스타일
    - container > row > col 형식으로 사용
    - 각 grid는 최대 12개까지 사용

- 정렬 클래스
    - * : start, center, end
    - text-*
    - align-items-*
    - align-self-*
    - justify-content-*

- 거터 : 갭(안쪽여백), padding과 동일
    - g, gx, gy, g-number, gx-number, gy-number
    - number : 1부터 5까지 사용가능
    - g : gx + gy
    - gx : 왼쪽, 오른쪽 안여백
    - gy : 위쪽, 아래쪽 안여백

- 여백을 위한 클래스
    - -number포함 : 1~5까지
    - p, ps, pt, pb, pe, px, py : padding
    - m, ms(left), mt, mb, me(right), mx, my : margin
    - start, top, end, bottom : 배율로 조정

- 컴포넌트 학습
    - Accordion
    - Alert : Button 클래스와 동일 primary ~ light(link는 없음)
    - Breadcrumb : 메뉴 경로
    - Navbar, Navs & tabs : 메뉴 내비게이션바
    - Button, Close button, Button group : 버튼관련 컴포넌트
    - Card, Placeholders, Modal, `Popovers`, Toasts, `Tooltips` : 화면 영역 컴포넌트
    - Pagination : 게시판 페이지 컴포넌트
    - Progress, Spinners : 프로그레스바, 대기용 컴포넌트
    - Carousel : 이미지 갤러리

    <img src="./image/web0005.png" width="600">

- 아이콘
    - [사이트](https://icons.getbootstrap.com/)
    - 부트스트랩이 지원해주는 아이콘
    - Python PyQt, leaflet.js(Folium) 등에도 사용가능
    - FontAwesome, XEIcon, Google Icon Fonts

#### 이미지팁
- 화면 UI 설계시 이미지 찾는 시간을 절약하기 위해 만든 사이트
- placehold image Site
    - [플레이스홀드](https://placehold.co/)
    - [로렙플릭커](https://loremflickr.com/)
    - [로렘픽섬](https://picsum.photos/)(추천)

#### 부트스트랩 템플릿 사이트
- 유료 템플릿
    - https://wrapbootstrap.com/templates 
    - https://themeforest.net/search/sns%20bootstrap : 필요한 소스코드도 구매가능
    - https://themewagon.com/theme-price/pro/
    - https://themes.getbootstrap.com/ 부트스트랩 공식 유료템플릿
- 무료 템플릿
    - https://startbootstrap.com/ : 무표 템플릿 중 최고
    - https://bootswatch.com/
    - https://bootstrapmade.com/ : 출처를 표기해야 함
    - https://themewagon.com/theme-price/free/
    - https://graygrids.com/templates/tag/bootstrap-5?type=free

### 프론트엔드 활용
- HTML5 + CSS3 + JS + BootStrap 응용예제
    - Bootstrap Image Gallery

    https://github.com/user-attachments/assets/fd0f5d4a-a8b7-4c84-bbad-cd682d40f5c0

    
## 4일차

### 프론트엔드 활용
- HTML5 + CC3 + JS 응용예제
- Modern Business 템플릿 클로닝
    - https://startbootstrap.com/template/modern-business 

    <img src="./image/web0006.png" width="700">

    - 압축파일 다운로드 후 압축해제

#### HTML5 Responsive Web template 
- https://html5up.net/

#### Modern Business 클로닝
1. 모든 웹페이지 시작은 index.* (.html, .asp, .jsp, .cshtml...)
2. 폴더 구성 : css, js, assets
3. favicon.ico 구성
4. Bootstrap 다운로드 후 폴더에 구성(not CDN)
    - bootstrap-5.3.6-dist.zip
5. Bootstrap Icon 링크 클릭 다운로드
    - https://github.com/twbs/icons/releases/tag/v1.13.1
    - bootstrap-icons-1.13.1.zip
    - css 폴더 아래 fonts 폴더 생성
    - bootstrap-icons.woff, bootstrap-icons.woff2 붙여넣기
6. body 마지막 Bootstrap js 링크 추가
7. body 내의 태그영역으로 나눠서 클로닝
    - div, main
        - div, nav
        - div, header
        - div, feature
        - div, testimonial
        - div, blog_section
    - div, footer
8. 태그 내에 Bootstrap 클래스 적용
9. Bootstrap Example의 테마 적용
10. 전체화면

    https://github.com/user-attachments/assets/d205515e-3edc-4a2a-a538-a08137dad2b1

## 5일차

### 웹개발 기술 용어
- SPA : Single Page Applicaiton. 페이지를 이동해도 새로고침 없이 한페이지에서 작동하는 웹
- MPA : Multi Page Applicaiton. 전통적인 여러페이지로 작동하는 웹
- CSR : Client-Side Rendering. 대부분의 SPA가 동작하는 방식. 렌더링을 브라우저에서 처리
- SSR : Server-Side Rendering. MPA가 위주. HTML을 서버에서 생성후 전달(naver, google 등 포털)

### ASP.NET Core 
- ASP : Active Server Page. Classic ASP라고 부름. 동적인 웹페이지를 만드는 기술
- 프론트엔드(HTML + CSS + JS) 상에서 동작하는 기술을 동적 웹페이지라고 부르지 않음
- 동적 웹페이지 : 사용자가 웹서버에 요청을 해서 값이 변경되는 것

    <img src="./image/web0007.png" width="600">

- IIS : Internet Information Service. MS가 윈도우 운영체제에 포함시킨 `웹 서버`
    - 윈도우 프로그램 추가 제거(appwiz.cpl)
    - 윈도우 기능 켜기/끄기 > 인터넷 정보 서비스 클릭 후 확인

- 윈도우 설정은 일반 사용자용, 제어판은 개발자용
    - 제어판 > Windows Tools > IIS(인터넷 정보 서비스) 관리자
    
    <img src="./image/web0008.png" width="600">

- Java가 1995년 출현하면서 Classic ASP, Classic VB 등의 옛날 MS기술이 위협
- 2000년 초반에 .NET 프레임워크를 출시
    - C#, VB(.NET) 새로운 언어 들이 포함됨
    - 위의 언어들로 개발할 수 있는 웹 기술인 ASP.NET 등장
    - 이후 언어는 계속 발전
    - 2016년에 크로스플랫폼 ASP.NET Core
    - 2020년에 .NET Framework(Windows전용)을 .NET 5.0(크로스플랫폼)로 변경

#### ASP.NET Core 장점
- 빠르다 : 초창기 ASP.NET은 C#으로 Winforms 만드는 것처럼 개발(개발생산성은 좋지만 렌더링 속도가 무지하게 느렸음). MVC모델로 분리하면서 윈폼식 개발을 제거
- 오픈소스 : Java JSP/Spring, Python Flask 등이 오픈소스로 발전하니까 MS도 오픈소스 전향
- 크로스플랫폼 : Windows에서만 동작하던 걸, MacOS, Linux 등으로 확대시킴
- 종속성 주입 : Dependencty Injection. Spring 쪽에 특화되던 기술을 접목해옴. 개발시간 절약
- 개발용 웹서버 : IIS가 Visual Studio에 포함. 웹서버 설정을 할 필요가 없음
- 클라우드 친화적 : MS Azure 등의 클라우드와 연계가 쉬움
- MVC 모델 : Model View Controller를 따로 개발. Spring Boot도 동일
- 최적화가 잘 되어 있음

#### ASP.NET Core 활용처
- `웹 사이트` 개발 : 기본적인 내용
- `풀스택` 개발 : 프론트엔드(React, Vue, Angular js) + 백엔드(ASP.NET Core)
- `API 서버` 개발 : TMDB 영화 데이터 조회 API, Youtube API, 데이터포털 API 등의 데이터만 주고받는 서비스 개발
- 도메인특화 솔루션 개발 : MES, ERP, SmartFactory, SmartShip 등
- 이커머스 개발 : 쇼핑몰, 온라인 서점, 여행예매 사이트 등

#### ASP.NET Core 시작
1. Visual Studio 시작 > 새 프로젝트 만들기
2. ASP.NET Core 웹앱(Model-View-Controller) 선택
3. 프로젝트 이름, 위치, 솔루션 이름 입력 
4. 추가정보
    - HTTPS : 보안 인증서를 신청, 다운로드 설정을 해야 함. 복잡, 체크해제
    - 최상위 문 사용 안함 만 체크 
5. 빌드 후 실행 
6. properties > launchSetting.json 에서 자신의 포트번호 확인
7. 기본 ASP.NET Core 웹앱에 포함된 프론트엔드 라이브러리
    - Bootstrap 5.1.0
    - jQuery 3.6.0
    - 최신버전으로 변경하고 싶으면 다운로드 받아서 구성하면 됨
    - 경로 - \wwwroot\lib\bootstrap\dist

#### ASP.NET Core 프로젝트 구조
- Properties > launchSettings.json - 웹서버 실행 설정
- wwwroot - 정적 리소스 구성한 폴더
    - css : 웹페이지 추가적인 css
    - js : 웹페이지 추가적인 js
    - lib : Bootstrap, jQuery 등의 라이브러리 포함된 폴더
    - favicon.ico : 웹페이지 대표 아이콘
- 종속성 : .NET 관련 NuGet 패키지 라이브러리(종속성)
- Controllers : MVC 패턴 중 Controller 관리
    - HomeController : Controller postfix는 제거하고 호출. Views에 postfix를 제거한 폴더 존재    
    - 메서드 : 메서드 이름과 동일한 cshtml이 존재
    - 비즈니스 로직이 포함
- Models : MVC 중 Model
    - 데이터, DB관련된 소스 포함
- Views : MVC 중 View 역할
    - Controller에 포함된 클래스와 동일한 이름의 폴더, cshtml이 존재
    - cshtml : HTML + ASP.NET 기술이 포함된 웹페이지
        - @, asp-append-version, asp-controller, asp-action 등의 속성
    - _Layout.cshtml : 전체 HTML 틀을 구성. @RenderBody()에서 표현
    - 웹사이트는 중간 content 이외는 모양이 항상 동일
    - cshtml 중 _로 시작하는 파일은 여러번 공유하겠다는 뜻
- appsettings.json : 로그 등 애플리케이션 설정
- Program.cs : C# 프로그램 시작점. 실제 웹앱이 시작될 때 필요한 초기화 담당
    - 중요 소스

    ```cs
    // ...
    app.UseStaticFiles();   // 정적인 HTML,CSS,JS를 사용하겠다
    app.UseRouting();       // 라우팅으로 URL을 사용하겠다
    app.UseAuthorization(); // 권한 설정을 사용하겠다
    // http://localhost:port/Home/Index/2 와 같이 URL을 사용하겠다
    // RESTful URL -> Rest API를 위한 요소 중 하나
    // Program.cs 에서 중요한 파트
    // controller의 Home, action의 Index는 Default값
    app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
    // ...
    ```

#### ASP.NET Core 페이지 생성법
1. 기존 Controller가 존재할 때
    - cshtml에 asp-controller, asp-action 속성 추가
    - Controller에 asp-action의 속성값과 동일한 메서드 추가
    - Views 폴더에 같은 이름의 cshtml을 생성, 작성

2. Controller가 없을때 1
    - Controllers 폴더에서 컨트롤러 생성
    - MVC 컨트롤러 - 비어있음 선택
    - SideController 클래스 생성
    - Index() 메서드에서 오른쪽 버튼 뷰 추가 선택
    - Razor 뷰 - 비어있음 선택
    - Index.cshtml 생성 후 작성

3. **Controller가 없을때 2**
    - `EntityFramework 사용하여 뷰가 포함된 MVC 컨트롤러` 또는 `읽기/쓰기 동작이 포함된 컨트롤러` 중 선택
    - BoardController 클래스 생성

        <img src="./image/web0009.png" width="600">

    - 메서드 Index() 부터 Delete() 까지 총 8개 메서드 생성
    - Models 폴더에서 모델 Board.cs 추가
    - 인덱스 마다 뷰 추가. Razor 뷰 선택(Razor 뷰 - 비어있음 아님!)

        <img src="./image/web0010.png" width="600">

        <img src="./image/web0011.png" width="600">

        - 템플릿 : Create, Delete, Details, List, Edit (DB의 CRUD와 매핑)
        - 모델 클래스 : MVC, MVVN에서 Model 클래스가 포함되어야 함 (DB 설정이 필요)

    - Razor 뷰 선택
    - Index.cshtml 생성
    - _Layout.cshtml 에 내비게이션 메뉴 추가

#### ASP.NET Core MVC

<img src="./image/web0012.png" width="650">

- MVVM과 MVC 패턴의 구조에대 설명할 수 있어야 함!
- 현재 기본적인 웹개발의 표준. Java도 Spring Boot MVC
- 프론트엔드가 심각한 스파게티 코드였으면 현재는 최소화하고 있음
- Razor 구문 : @로 시작하는 C# 문법에 대한 이해

- DB 연동방법
    - 전통적인 방법 : WPF나 윈앱에서 연동방법. SQL쿼리문을 직접 작성, 실행
    - 현대적인 방법 : EntityFramework 방식. 쿼리를 사용하지 않음
        - DB First : DB를 설계해 놓고, 연결, 사용하는 방식
        - Code First : 모델 클래스만 만들어 놓고, EF가 DB에 테이블을 자동 생성


#### ASP.NET Core MVC - Kelly Portfolio 디자인 클로닝
1. Kelly-1.0.0.zip 다운로드
2. 정적파일 분석
3. index.html 오픈, VS Views > Shared > _Layout.cshtml 디자인 태그 옮기기
4. wwwroot 내 vendor 에서 Bootstrap 관련 폴더삭제   
    - php 관련도 추후 삭제 필요
5. _Layout.cshtml 작업

    <img src="./image/web0013.png" width="600">

## 6일차

### ASP.NET Core

#### ASP.NET Core MVC - Kelly Portfolio 디자인 클로닝(계속)
1. Properties> launchSettgins.json
    - hotReloadEnabled 설정키 추가
2. _Layout.cshtml 작업 계속
    - head, nav, footer, script영역 공통부분 
    - main.js 소스를 site.js로 복사/붙여넣기
    - 원본 head의 google font 태그 그대로 사용
    - ASP.NET Core에서 생성한 <link rel="stylesheet" href="~/MyPortfolioWebApp.styles.css" asp-append-version="true" /> 주석처리
3. 원본 이미지 등 정적리소스를 변경시 반영안되는 경우
    - 웹브라우저에 캐시가 남아있기 때문
    - 웹브라우저 설정 > 개인정보 보호 및 보안 > 인터넷 사용기록 및 삭제 > 전체삭제
    - 웹브라우저가 없는 리소스는 재다운로드
4. HomeController에 About 메서드 생성
    - 뷰 추가
    - ASP.NET Core 링크 asp-controller, asp-action 속성을 사용해야
5. About.cshtml부터 Contact.cshtml까지
    - CSS 부터 적용
   
6. DB연동
    - NuGet 패키지
        - Bogus (Python Faker 라이브러리)
        - `Microsoft.EntityFrameworkCore` 8.0.x
        - `Microsoft.EntityFrameworkCore.Tools` 8.0.x
        - `Pomelo.EntityFrameworkCore.MySql` 8.0.3
        - EntityFrameworkCore는 전부 Version Major 숫자가 일치해야 함(현재 8버전)
    - **EntityFramework** `Code First` 방식 - C#으로 클래스 작성하고 위저드를 통해서 DB를 만드는 방식
        - DB를 잘 몰라도 웹개발 가능토록 만든 기술

    - Model > News 클래스 생성
    - appsettings.json, DB연결문자열 추가
    - Model > ApplicationDbContext 클래스 생성
    - Progam.cs에서 초기화 설정에 DB연결을 추가

    - 도구>NuGet패키지 관리자> 패키지 관리자 콘솔로 진입. 아래의 1, 2번 명령어를 순차적 실행
        ```shell
        PM1> add-migration AddNewsToDatabase
        Build started...
        Build succeeded.
        To undo this action, use Remove-Migration.
        PM2> update-database
        Build started...
        ...
        Build succeeded.
        ...
        Done.
        PM>
        ```
    - MySQL Workbench 해당 스키마(DB)에 News 테이블 생성 확인, 더미데이터 입력
    - NewsController 클래스 생성
    - `Entity Framework를 사용하여 뷰가 포함된 MVC 컨트롤러` 선택

    <img src="./image/web0014.png" width="600">

7. Controller 설명
    - CRUD 중
        - SELECT는 GET메서드만 존재
        - 데이터가 처리되면 INSERT, UPDATE, DELETE 기능에는 GET, POST메서드 둘 다 필요
        - form 태그의 `asp-action`이 POST 메서드

8. 개발콘솔에서 CRUD 로그 확인

    <img src="./image/web0015.png" width="600">

9. 작업화면

    https://github.com/user-attachments/assets/33b49f9b-946b-44ae-9ad2-ae6521bf1e7d
    

## 7일차

### ASP.NET Core

#### EntityFramework DB First
- DB를 먼저 설계하고 관련된 C#코드를 위저드가 자동으로 만들어주는 방식
- EntityFramework DB연동방식 : ORM(Object-Relational Mapping) 방식
    - 제일 최근의 DB연동기법
    - Spring Boot JPA, myBatis 과 동일
    - EntityFramework - WPF, 윈앱, 웹앱
- DB의 테이블 내용을 VS Models에 가져온 이후는 Code First, DB First 작업이 동일
- 자동 완성으로 그냥 사용은 불가. 수정이 필요

#### EF DB First 연습
1. 프로젝트 생성
2. NuGet 패키지 관리자
    - Microsoft.EntityFrameworkCore 8.0.16
    - Microsoft.EntityFrameworkCore.Tools 8.0.16
    - Microsoft.EntityFrameworkCore.Design 8.0.16 (옵션)
    - `MySql.EntityFrameworkCore` 8.0.14 (DB First시 반드시 필요!!)
    - Pomelo.EntityFrameworkCore.MySql 8.0.3
3. appsetting.json에 DB연결 문자열 추가
4. NuGet 패키지 관리자 콘솔에서 해당 프로젝트로 변경(기본프로젝트 드롭다운)
5. 아래 내용 입력

    ```shell
    PM> dir
        디렉터리: C:/Source/iot-webapp-2025/day07/Day07Study

    Mode                 LastWriteTime         Length   Name                                                                                                                                      
    ----                 -------------         ------   ----                                                                                                                                      
    d-----        2025-05-30   오전 9:32                DbFirstWebApp
    d-----        2025-05-30   오전 9:22                MyPortfolioWebApp                                                                                                                         
    -a----        2025-05-29   오전 9:35           1158 Day07Study.sln  

    PM> cd ./DbFirstWebApp  
    PM> Scaffold-DbContext "Server=localhost;Database=bookrentalshop;Uid=root;Pwd=12345;Charset=utf8;" 
        MySql.EntityFrameworkCore -OutputDir Models
    Build started...
    Build succeeded.
    ...
    PM> 
    ```
6. Visual Studio 프로젝트 Models 폴더 생성된 클래스 확인
7. Program.cs DB연결 초기화 추가
8. BookrentalshopContext.cs 내 OnConfiguring 메서드 주석처리!
9. BookController 컨트롤러(Entity Framework를 사용하여 뷰가 포함된 MVC 컨트롤러) 생성
10. _Layout.cshtml 네비게이션 메뉴 추가
11. 실행확인

    <img src="./image/web0017.png" width="600">

12. 자동으로 만들 경우의 문제점
    - Model의 관계 부분에서 부모로의 연결이 Not Null로 연결됨. CUD 작업 불가
    - EF Core의 탐색 속성(Navigation Property)
    - = null!로 정의되어 있어서 EF Core는 내부적으로 필수(NOT NULL) 관계라고 간주
    - public virtual Divtbl DivisionNavigation { get; set; } **= null!**; 
    - public virtual Divtbl? DivisionNavigation { get; set; } 로 변경

    - HACK : 자동 생성 후 수정 주석부분 확인 | BookController, Model, View 확인할 것

    <img src="./image/web9998.png" width="600">

13. WebEditor 클라이언트 라이브러리 Trumbowyg 설치
    - 클라이언트 라이브러리 추가

    <img src="./image/web9997.png" width="600">

14. Markdown Viewer
    - NuGet 패키지 관리자, Westwind.AspNetCore.Markdown 설치

15. 메일관련
    - [소스확인](./ref/Day07Study/MyPortfolioWebApp/Controllers/HomeController.cs)

16. 메뉴 활성화
    - _Layout.cshtml 내에 작성

    ```cs
    // cshtml 상단.
    @using Microsoft.AspNetCore.Mvc.Rendering
    @inject Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper Html

    @functions {
        bool IsActive(string controller, string action)
        {
            var routeData = ViewContext.RouteData;
            var currentAction = routeData.Values["action"]?.ToString();
            var currentController = routeData.Values["controller"]?.ToString();

            return string.Equals(controller, currentController, StringComparison.OrdinalIgnoreCase)
                && string.Equals(action, currentAction, StringComparison.OrdinalIgnoreCase);
        }

        string ActiveClass(string controller, string action) =>
            IsActive(controller, action) ? "active" : "";
    }
    ```

    ```html
    <li><a asp-controller="Home" asp-action="Index" class="@ActiveClass("Home", "Index")">Home</a></li>
    ```

## 8일차

#### ASP.NET Core MVC - Kelly Portfolio 디자인 클로닝(계속)
1. 뉴스 게시글 수정
    - 리스트 CSS 작성(제목줄 스타일, 행별 배경색, 마우스오버시 배경색변경)
    - Model에서 Validation Check 에러나는 타입은 string밖에 없음
    - public string Writer -> `public string? Writer`로 변경!!
    - Create.cshtml과 Edit.cshtml에서 필요없는 `입력값 필드`(Writer, PostDate, ReadCnt) 삭제
    - 뷰화면 스타일 조정(container 넓이) 맞추기
    - Create, Edit `포스트 메서드 수정`
    - Delete는 간단함
    - 뉴스 조회건을 최신건을 위로 정렬
2. 게시글 조회수 올리기
3. 토스트 메시지
    - 컨트롤러에서 뷰에 보이고 싶은 데이터를 전달하는 변수
        - ViewData, ViewBag, TempData 등
    - Partial View 생성

        <img src="./image/web0019.png" width="500">

        - View.cshtml -> _Notification.cshtml 변경
        - Index.cshtml에 TempData로 집어넣은 부분을 이동
        - Index에 `<partial name="_Notification">` 추가
    - Toastr 클라이언트 라이브러리 사용
        - Github 설명대로 css, js 링크 추가
    - _Notification.cshtml 코드 수정

4. HTML 에디터 추가
    - 본문 내용을 HTML화 해서 괜찮은 디자인의 컨텐츠가 되도록 만드는 컴포넌트
    - 유사한 라이브러리 : Trumbowyg, CKEditor 5(기능최대), summernote, TinyMCE, Quill(단순)
    - Trumbowyg 클라이언트 라이브러리 설치(NuGet패키지와 차이있음)
    - wwwroot > 마우스오른쪽 > 추가 > 클라이언트 쪽 라이브러리
    - Trumbowyg 검색 후 설치

        <img src="./image/web0020.png" width="500">

    - _Layout.cshtml에 css, js 링크 추가
    - Create.cshtml, Edit.cshtml `<input asp-for="Descrption">` -> `<textarea>` 로 변경
    - Site.js 마지막에 trumbowyg 초기화 함수 추가작성
    - 뷰어 라이브러리 : Westwind.AspNetCore.Markdown NuGet패키지 라이브러리
    - Detail.cshtml, Delete.cshtml에 라이브러리 using Westwind.AspNetCore.Markdown 추가
    - Description 태그 부분 수정 @Markdown.ParseHtmlString(Model.Description)

        <img src="./image/web0021.png" width="600">

5. EntityFramework로 자동 생성된 테이블 컬럼타입변경
    - LONGTEXT로 타입이 지정된 컬럼은 사용여부에 따라 VARCHAR(num)로 변경

        <img src="./image/web0022.png" width="600">

5. 페이징
    - 웹페이지 게시판에서 가장 중요한 기능. 가장 일반적인 데이터 로딩 방식
    - 한 페이지에 대량의 데이터를 부르면 성능문제 발생
    - EntityFramework에서 쿼리, 저장프로시저 사용가능

        ```sql
        CREATE PROCEDURE `New_PagingBoard`(
            startCount int,
            endCount int    
        )
        BEGIN
            -- 제일 중요한 값은 ROW_NUMBER()
            SELECT * 
            FROM (
            SELECT ROW_NUMBER() OVER (ORDER BY Id DESC) AS rowNum,
                    Id, Writer, Title, Description, PostDate, ReadCount
                FROM News
            ) AS b
            WHERE b.rowNum BETWEEN startCount AND endCount;

        END
        
        ```

    - 저장프로시저는 CALL New_PagingBoard(1, 10), CALL New_PagingBoard(11, 20) 식으로 호출
    - NewsController Index() 메서드 완전 수정!
    - index.cshtml에 Viewbag 영역 복사

        ```html
        @{
            // 컨트롤러 변수값이 바로 사용할 수 없음
            // ViewBag, ViewData, TempData로 전달
            var startPage = ViewBag.StartPage;
            var endPage = ViewBag.EndPage;
            var page = ViewBag.Page;
            var totalPage = ViewBag.TotalPage;
        }
        ```

    - index.cshtml 게시판 영역 아래에 페이징부분 작성

        <img src="./image/web0023.png" width="600">

## 9일차 (25.06.04.)

### ASP.NET Core 실습

#### ASP.NET Core MVC - Kelly Portfolio 클로닝 (계속)
1. 뉴스페이징 완료
    - 페이징 첫페이지, 이전페이지, 다음페이지, 마지막페이지 링크 추가
    - Bootstrap 디자인 적용
2. 검색
    - 검색 폼 추가
    - 컨트롤러 Index() 메서드에 검색어 파라미터 추가
    - 쿼리 변경(카운트 쿼리, 저장프로시저 검색부분)
    - 페이징 부분 GET메서드에 검색어 파라미터추가

        <img src="./image/web0024.png" width="600">

3. 한글화
    - 각 페이지 한글로 입력변경

4. 정적페이지 DB연동
    - About, Skill 모델 생성
    - NuGet 패키지 관리자 콘솔
        - Add-Migration
        - Update-Database
    - HomeController의 About() 메서드에서 DB연동
    - About.cshtml에 데이터변수 사용

5. 회원가입/로그인
    - ASP.NET Core Identity API
    - 사용자, 암호, 프로필데이터, 역할, 메일확인... 작업과 Google OAuth 연동 가능
    - NuGet 패키지 - Microsoft.AspNetCore.Identity.EntityFrameworkCore 설치
    - Models.ApplicationDbContext 에서 기반클래스를 IdentityDbContext로 변경
    - Program.cs 내용 추가

        ```cs
        // ASP.NET Core Identity 설정!
        builder.Services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

        var app = builder.Build();

        // ...

        app.UseStaticFiles();

        app.UseRouting();
        app.UseAuthentication();  // ASP.NET Core Identity 계정!
        app.UseAuthorization();   // 권한
        ```

    - NuGet 패키지 관리자 콘솔

        ```bash
        PM> Add-Migration InitialIdentity
        Build started...
        Build succeed.
        Done.
        PM> Update-database
        // DB생성
        Done.
        ```

    - MySQL Workbech에서 추가된 7개 AspNet* 테이블 확인

        <img src="./image/web0025.png" width="450">

## 10일차

### Visual Studio 개발 Tip
- 이전 솔루션을 복사하고 나서 MSBuild에서 오류가 발생할 가능성이 있음
- 이를 대비해서 프로젝트 내 bin, obj 폴더를 삭제 후
- VS를 다시 실행하면 bin, obj 폴더를 재생성

### ASP.NET Core 실습

#### ASP.NET Core MVC - Kelly Portfolio 클로닝 끝
1. 회원가입/로그인 계속
    - 자동생성 테이블
        - AspNetRoleClaims : 역할 내 모든 사용자에게 부여되는 클레임(권리 - 편집가능, 작성가능, ...)
        - AspNetRoles : 역할저장 테이블(관리자, 사용자, 뷰어...)
        - AspNetUserClaims : 사용자가 소유한 클레임
        - AspNetUserLogins : 사용자를 로그인에 연결
        - AspNetUserRoles : 사용자테이블, 역할테일을 연결하는 Join entity
        - `AspNetUsers` : 사용자정보 테이블
        - AspNetUserTokens : 사용자 인증토큰 테이블
    - Models.RegisterModel 클래스 생성
    - AccountController 클래스 생성
        - Register(), Login() Get/Post 메서드 추가
    - Regiser 뷰 추가
    - Login 뷰 추가
    - 각 기능별 버튼, 링크 추가

2. 회원가입 정보 확장
    - Models.CustomUser 클래스 생성. IdentityUser를 상속. City, Mobile, Hobby 속성 추가
    - Program.cs 에서 IdentityUser -> CustomUser로 변경
    - AccountController 에서 IdentityUser -> CustomUser로 변경
    - _Layout.cshtml, News.Index.cshtml, News.Detail.cshtml에 IdentityUser -> CustomUser로 변경
    - ApplicationDbContext.cs에서 IdentityUser -> CustomUser로 변경
    - NuGet 패키지 관리자 콘솔에서
        - Add-Migration (이름) 실행, Update-Database 실행
    - Account.Register.cshtml 입력양식 추가
    - AccountController.cs Register() Post 메서드 수정
    - Program.cs에서 패스워드 정책을 간단하게 변경

3. 게시판 준비
    - MySql Workbench에서 Board 테이블 생성
    - NuGet 패키지 관리자 콘솔에서 DB스캐폴드
        - Scaffold-DbContext "Server=localhost;..." Pomelo.EntityFrameworkCore.MySql -OutputDir BackupModels
    - BackupModels에서 필요한 모델클래스를 Models 이전, 수정
    - ApplicationDbContext에 `DbSet<Board>` 추가
    - Controller에 BoardController 클래스 스캐폴딩 생성

4. 이후 작업
    - HomeController Contact() Post메서드 신규 추가
    - 메일관련 작업 - Pendding

## 11일차

### ASP.NET Core API서버(Web API)
- 2000년도 초반, 웹서비스 이름의 변형
- 웹을 통해서 데이터전달이 목적
- API서버, WebAPI, RESTful Service, OpenAPI(공용)... 
- 초기에는 XML을 데이터 전달로 사용
- XML의 방대한 데이터크기때문에 현재는 JSON으로 거의 이전(XML의 1/3수준)
- WebAPI 서버 사용처
    - 하나의 서비스로 여러가지 앱에서 같이 사용할때
    - 회사 ERP를 웹사이트, 모바일, PC앱으로 동시에 사용할때
    - 알라딘 웹사이트, 모바일, PC책뷰어...

#### Web API 만들기
1. ASP.NET Core 웹 API로 프로젝트 생성
2. Swagger 화면 확인
3. Prgram.cs 소스 분석
4. WeatherForecast 모델 클래스 확인
5. WeatherForecastController 클래스 확인

#### 웹서비스를 테스트 툴
1. 웹브라우저 - URL을 입력, json뷰어확인
2. Swagger UI - Visual Studio에 포함
3. [Postman](https://www.postman.com/) - 가장 기능이 다양

    <img src="./image/web0029.png" width="600">

#### 웹서비스 4가지 메서드
- 일반 웹사이트에서의 GET/POST는 동일
- `GET` - 리소스(데이터) 조회
- `POST` - 요청 데이터 처리(저장, 수정, 삭제). 주로 등록에 사용
- `PUT` - 리소스 대체, 주로 수정에 사용
- `DELETE` - 리소스 삭제, 주로 삭제에 사용
- PATCH - 리소스 부분 변경(수정). 거의 사용안함. PATCH메서드를 지원하지 않으면 PUT으로 대체

#### WebAPI CRUD 작업 연습
|API|설명|Request body|Response body|
|:--|:--|:--|:--|
|GET ~/api/books|모든 책정보 가져오기|None|책정보 배열|
|GET ~/api/books/{id}|특정 책정보 가져오기|None|책정보 한 건|
|POST ~/api/books|새 책 추가|Book 데이터|Book 데이터|
|PUT ~/api/books/{id}|기존책 수정|Book|None|
|DELETE ~/api/books/{id}|기존책 삭제|None|None|

<img src="./image/web0026.png" width="600">

1. WebAPI 프로젝트 생성
2. Models.Book 모델 클래스 생성
3. EntityFramework NuGet패키지 설치
    - Microsoft.EntityFrameworkCore
    - Pomelo.EntityFrameworkCore.MySql    
4. appsettings.json DB연결문자열 추가
5. MySQL Book 테이블 생성
6. Models.AppDbContext 클래스 생성
7. Program.cs AppDbContext 초기화 추가
8. 스캐폴딩으로 Controller 생성
    - API > EntityFramework 사용 동작이 포함된 API컨트롤러 선택

    <img src="./image/web0027.png" width="600">
9. 서버 실행

    <img src="./image/web0028.png" width="600">

#### OpenAPI 형식 WebAPI 연습
1. IoT 센서데이터를 웹API 서비스
2. Python에서 더미데이터 100만건 생성
3. WebAPI 프로젝트 생성
4. EntityFramework NuGet패키지 설치
5. appsettings.json DB연결문자열 추가
6. MySQL iot_datas 테이블 생성
7. Models.iot_datas 클래스 생성
8. Models.AppDbContext 클래스 생성
9. Program.cs AppDbContext 초기화 추가
10. 스캐폴딩으로 Controller 생성
    - Get 메서드 외 모두 삭제
11. Get 메서드 파라미터 추가, 쿼리 실행 로직 추가
12. Swagger UI에서 테스트

    <img src="./image/web0030.png" width="600">

13. 웹브라우저 실행 확인

    <img src="./image/web0031.png" width="600">

## 12일차

### ASP.NET Core API서버(계속)

#### WebAPI 서버 + 윈앱(WPF)
- 웹사이트나 WPF 윈앱에서는 DB연동 없이도 데이터 처리가 가능!!
- Todo List 오늘할일 API 서비스

    |API|설명|Request body|Response body|
    |:--|:--|:--|:--|
    |GET /api/todoitems|모든 할일정보 가져오기|None|할일정보 배열|
    |GET /api/todoitems/{id}|특정 할일정보 가져오기|None|할일정보 한 건|
    |POST /api/todoitems|새 할일 추가|todoItem 데이터|todoItem 데이터|
    |PUT /api/todoitems/{id}|기존할일 수정|todoItem 데이터|None|
    |DELETE /api/todoitems/{id}|기존할일 삭제|None|None|

    1. 프로젝트 생성
    2. 패키지 설치
    3. DB구성, 생성
    4. 컨트롤러 생성(내용 생략, 위에 다있음)

- WPF앱 API 사용 - 데이터포털로 부산맛집정보앱, 영화즐겨찾기와 동일(GET메서드만 사용)
    1. WPF 프로젝트 생성
    2. NuGet 패키지 관리에서 패키지 설치
        - MahApps.Metro / IconPacks
        - Microsoft.AspNet.WebApi.Client 
    3. UI 설정
    4. 모델설정, 컬렉션 설정
    5. WebAPI 호출로 CRUD 구현

    <img src="./image/web0032.png" width="600">

## 13일차

### ASP.NET Core API서버(계속)

#### WebAPI 서버 + 웹사이트
- WebAPI 서버는 전일자 프로젝트 사용
- ASP.NET Core 프로젝트에서 정적페이지HTML, 동적페이지cshtml 동시 사용가능
- 웹사이트만 새로 생성
    1. ASP.NET Core 비어있음 으로 프로젝트 생성
    2. wwwroot/html/index.html 파일 생성 - VS Code의 Live Server 예제와 동일(정적페이지)
    3. Program.cs에서 MVC패턴 관련된 로직 추가
    4. Controllers/HomeController.cs 생성
    5. Index() 메서드에서 뷰 추가 - ASP.NET Core 동적페이지
    6. Views 폴더 하위 파일들이 필요
        - _ViewImports.cshtml
        - _ViewStart.cshtml
        - Shared/_Layout.cshtml.css 
    7. index.html에 화면UI 구현
    8. AJAX로 WebAPI 호출하고 데이터를 화면에 뿌리는 로직 추가
    9. input 태그로 검색부분 구현
        - Javascript와 데이터를 주고받으면 form태그가 없어도 됨
        - `<form>` - 서버사이드와 데이터를 주고 받을때 필요
    10. 입력부분 구현
    11. jQuery 로직 구현

- AJAX : Asyncronous Javascript And Xml. 자바스크립트에서 비동기로 메서드를 호출 기술
    - 예전에 XML로만 데이터 전달. 현재는 Json으로 이전 중

- CORS Policy : Cross-Origin Resource Sharing. 다른 출처 리소스 접근허용 보안 메커니즘
    - 아무나 URL로 호출을 못하도록 웹페이지 보안설정
    - WebAPI 서비스에서 Program.cs에 CORS 호출권한 설정 추가
    - 프론트엔드는 CORS 설정 필요없음

    <img src="./image/web0033.png" width="400">

## 14일차

### ASP.NET Core API서버(계속)

#### WebAPI 서버 + 웹사이트(계속)
- 할일 수정/삭제
- 실행화면

    <img src="./image/web0034.png" width="600">

- 결론
    - WebAPI로 백엔드를 운영하면 프론트는 모두 사용가능(윈앱, 웹앱, 모바일앱)

### AWS 클라우드 업로드
- 클라우드서비스 사용 : 어디서나 웹사이트 공개
- 온프레미스 : 직접 서버를 구축. DB서버구축, 웹서버구축 등 직접 운영
    - 서버 하드웨어 구매, 서버실 구축, UPS구성, 네트워크 스위치구성
    - OS구매, SW구매, 운영환경구성, 개발환경구성
    - 운영하면 문제 해결, 유지보수
- 클라우드 : 서버구축 필요없음. DB서버 신청 생성
    - 서버실 구축x, 하드웨어 구매x, SW구매x, 운영문제 관리x
    - 최초 구축비용이 들지 않음
    - 사용료가 저렴하지 않음

- AWS 라이트세일 - https://aws.amazon.com/ko/lightsail/
    - 기존 AWS보다 저렴하게 사용할 수 있는 서비스

#### AWS 라이트세일에 웹서버 올리기
1. 인스턴스 생성
    1. Microsoft Windows > Windows Server 2019 > 
    2. 네트워크 듀얼스택 
    3. 크기, 월별 $9.5 선택 `90일 무료`
    4. 인스턴스 이름 
    5. 인스턴스 생성
2. 인스턴스 관리 > RDP를 사용하여 연결
    1. 초기화 대기(네트워크 나올때까지, 1분가량)
    2. Network2 허용 Yes 클릭
    3. Server Manager 오픈
        - Configure this local server
        - IE Enhanced Security Config : ON(웹사이트 오픈 불가) -> OFF
3. 필요 SW 다운로드
    1. MySQL Installer for Windows
    2. Chrome browser(option)
    3. FileZilla FTP Server 
4. MySQL 설치
    1. Custom 선택
    2. MySQL Server 8.0.42 - x64 만 선택, 설치 후 Next
    3. 일반적으로 Next
    4. Authentication Method > Use Legacy Authentication (Retain MySQL 5.x Compatibility) 선택
        - 암호정책이 간결
        - 대신 AWS는 IP나 공개된 상황이라 간단한 암호하면 절대 안됨
    5. 나머지는 Next, Execute 실행
    6. 마지막에 Finish 클릭
    7. Firewall & Network Protection 실행 > Advanced setting 선택
        - Inbound Rules > Port 3306 확인, 없으면 생성
    8. 라이트세일 인스턴스 관리 > 네트워크
        - IPv4 방화벽에 규칙추가
    9. MySQL Workbench 접속 생성/확인

5. FileZilla FTP 서버 설치
    1. 설치는 Next로 설치
    2. 서버 시작 후
    3. 메뉴 Server > Configure
        - Server listener의 아이피 0.0.0.0 -> 본인의 내부서버 아이피로 변경
    4. 프로토콜 셋팅 > FTP and FTP over TLS 메뉴
        - Connection Security
            - Generate new 버튼 클릭 후 OK
        - Passive Mode
            - Use custom port range 클릭
            - From : 55000
            - To : 55999   
    5. 탐색기 오픈, Website 폴더 생성     
    6. Right Management > Users 사용자 계정 생성
        - 사용자 생성
        - Mount points
            - Virtual Path : / (root)
            - Native path : 탐색기에서 만든 Website 지정
    7. Firewall & Network Protection > Advanced setting
        - Inbound Rules
        - New Rule
            - Program FileZilla Server 선택
            - 전부 오픈
    8. 라이트세일 인스턴스 관리
        - 네트워크 IPv4 방화벽에서 21, 55000~55999 포트 오픈

    9. 로컬PC에 파일질라 클라이언트 설치
        - 접속확인

6. Visual Studio 프로젝트 오픈(MyPortfolioWebApp)
    1. 게시 > FTP/FTPS 선택
    2. 서버 - ftps://aws-public-ip
    3. 사이트경로 - /
    4. 수동모드 - 체크
    5. 사용자이름/패스워드 - FileZilla 서버 설정한 계정
    6. 연결유효성후 인증서 승인

7. MySQL Workbench
    1. Local DB의 데이터베이스 Server > Data Export로 백업
    2. AWS MySQL Workbench에서 FTP로 전달한 sql을 Server > Data Import로 복구
    3. 저장프로시저는 쿼리 복사해서 재실행

## 15일차

### AWS 클라우드 업로드

#### 14일차 확인한 문제
- FileZilla FTP와 연동 VS에서 FTP로 게시할때 업로드 문제
- 파일자체는 업로드 성공, 실패메시지가 리턴
- 다른 방법
    - IIS + WebDeploy : 현재 문제발생
    - IIS FTP 사용 : 해결방법

#### AWS 라이트세일 웹서버 올리기(계속)
1. 인스턴스 진입
    1. 서비스 오픈 > FileZilla-Server 중지(Startup type Manual)
    2. Server Manager 실행 -> Add roles and features
        - Role-based or feature-based installation -> 자기 서버 선택 Next
        - 아래 기능 설치
            - WebServer IIS 선택 후 Add Features
            - Health And Diagnostics -> Logging Tool, Request Monitor 추가 선택
            - Application Deployment -> ASP.NET 4.8, ISAPI Extenstions, ISAPI Filters 추가 선택
            - FTP Server 아래 전부 선택
    3. asp.net core hosting bundle 8.0 웹브라우저 검색

        <img src="./image/web0037.png" width="500">

        - https://dotnet.microsoft.com/en-us/download/dotnet/8.0
        - aspnetcore-runtime-8.0.17-win-x64.exe 그냥 설치
    4. dotnet-hosting-8.0.17-win.exe 설치
        - 콘솔(파워쉘)에서 iisreset 실행

        <img src="./image/web0038.png" width="600">

    5. IIS 서비스 
        - Modules -> `AspNetCoreModuleV2`가 있는지 확인
        - Add FtpSite...
            - 이름, 물리적 경로 선택
            - IP/All Unassigned, Port/21, SSL/Allow SSL 선택
            - Authentication : Basic, 사용자 Administrator, 암호는 인스턴스 암호사용
            - Authorization : permission, READ/WRITE 둘다 체크
    6. Application Pool 생성
        - ASPNETCore Pool 생성

        <img src="./image/web0039.png">
        
    7. OS방화벽, AWS 인스턴스 방화벽
        - OS방화벽에는 21, 1024-65535 전부 오픈
        - AWS 인스턴스 네트워크도 동일하게 오픈

    8. IIS 서비스 
        - WebSite 생성 > Add Website
        - SiteName 옆 Applicaiton Pool을 Select버튼, ASPNetCore를 선택!

2. 90일 이후
    - AWS 라이트세일 내
    - 비용발생, 반드시 인스턴스 삭제할 것    

### 부가적인 기능
- 파일업로드
- OAuth (구글로그인)

#### 웹사이트 파일업로드 기능 구현
1. Model.News
    - UploadFile 속성 추가
2. MySQL Workbench
    - News 테이블 UploadFile 컬럼 추가
    - 운영중인 테이블에 새 컬럼을 추가하면 `Not Null로 설정불가`!
3. New_PagingBoard 저장프로시저 오류 수정
    - UploadFile 컬럼 추가되어 생기는 오류
4. Views/News/Create.cshtml
    - 입력양식에 파일입력 추가
    - form 태그에 파일업로드 enctype="multipart/form-data" 속성 추가
5. wwwroot/upload 폴더 추가
6. Controller/NewsController.cs
    - Create() Post메서드에 파일 파라미터 추가
    - 파일 저장 로직 추가
7. Views/News/Details.cshtml, Delete.cshtml 동일
    - 파일 다운로드 영역 추가
8. Views/News/Edit.cshtml 
    - 파일업로드 영역 추가(Create.cshtml과 유사)
9. Controller/NewsController.cs 
    - Edit() Post메서드에 파일 파라미터 추가
    - 파일저장 로직 처리(Create() 메서드 로직 복사)
10. VS IIS Express 사용시
    - 최대 30MB 제약 걸려있음 - ERR_CONNECTION_RESET 발생
    - 업로드 크기를 제한을 두더라도 최대사이즈는 설정필요
11. Program.cs 
    - 최대 업로드 크기 설정

    <img src="./image/web0040.png" width="600">

### 개인포트폴리오 게시판 완료