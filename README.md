# ASP_NET_project
공공API를 이용한 유실물 검색 웹 서비스


# database 생성(맥에서 테스트, 윈도우환경에서 안되면 검색해보셔야할듯)
1. CLI에서 asp_net directory로 이동
2. dotnet ef시 설치하라뜨면
3. dotnet tool install --global dotnet-ef 입력
4. dotnet add package Microsoft.EntityFrameworkCore.Design 입력
5. dotnet ef 입력 후 설치확인
6. dotnet ef database update 입력 후 db생성 확인

# 웹 실행 시 오늘자 데이터를 받아옵니다
# DB에 저장이 안되어있으면 모든데이터 '디비에 저장' 눌러주시면 됩니다.
