# 1번 문제

주어진 프로젝트 내에서 CubeManager 객체는 다음의 책임을 가진다
- 해당 객체 생성 시 Cube프리팹의 인스턴스를 생성한다
- Cube 인스턴스의 컨트롤러를 참조해 위치를 변경한다.

제시된 소스코드에서는 큐브 인스턴스 생성 후 아래의 좌표로 이동시키는 것을 목표로 하였다
- x : 3
- y : 0
- z : 3

제시된 소스코드에서 문제가 발생하는 `원인을 모두 서술`하시오.

## 답안
- _cubeController에 할당된 CubeController가 있는 인스턴스가 할당되기 전에 SetPosition을 호출함
- _cubeController의 위치를 조정화기 위해 SetPoint를 이용하는데, 해당 SetPoint를 설정할 때, private로 접근 제한이 되어 있음 (변수명으로 추측하면, 해당 접근 제한은 public이라 판단)
- _cubeController의 SetPoint가 _cubeSetPoint를 설정하는 것이 아닌, 반대로 설정되어야 함.
- _cubeController의 SetPosition()을 통해 위치가 조정되길 바라므로, 해당 메소드를 호출.

