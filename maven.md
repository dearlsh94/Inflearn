# maven

## Infos

## Goal

- Maven이 행할수 있는 여러가지 동작을 수행하는 명령을 Goal이라고함
- 실행 방식, 체인 형태로 실행가능

```
$ mvn [goal명령어] [goal명령어] [goal명령어] 
```

- goal 종류

  - clean : 컴파일 결과물인 `target` 디렉토리 삭제

  - compile : 모든 소스코드 컴파일, 리소스파일을 `target/classes` 디렉토리에 복사

  - package : `compile` 수행 후, 테스트 수행, `` 정보에 따라 패키징 수행

  - install : `package` 수행 후, local repo에 install 수행

  - deploy :

    ```
    install
    ```

    수행 후, 배포 수행, 여기서 배포는 웹서버에 배포가 아니다. 회사 repo에 배포다.

    - 아래와 같이 `distributionManagement` 항목이 기술되어야 한다.









## Errors

###  Failed to execute goal

####  Issue

- Failed to execute goal org.apache.maven.plugins
- JRE 경로가 잘못 설정 된 것.
- JAVA > JDK 안에 있는 JRE 를 선택 해주면 된다.

#### Solution

- Windows -> Preferences -> Java -> Installed JREs -> jdk 
- edit
- JAVA > JDK > JRE 경로로 수정