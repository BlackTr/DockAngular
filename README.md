# Prerequistes
- [git](https://git-scm.com/)
- [docker](https://www.docker.com/)

#### steps:
1. clone repository
2. launch:
```
docker-compose up #run
OR
docker-compose up -d #run in detached mode
```
Navigate to [localhost:4200](localhost:4200)

#### stop containers:
```
docker-compose down
```

#### change entities (and/or db structure):
1. change in code
2. restart containers->new migration will be generated