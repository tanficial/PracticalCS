namespace DistanceConverter;
public static class FeetConverter {
    // const는 자동으로 static이라고 해석되어 static 키워드 붙일 필요가 없음
    // const로 지정한 상수는 public으로 선언하지 말것 : 버전관리에 문제 발생
    // const로 지정한 값은 빌드 시점에 결정 된다.
    // 따라서 const 값이 변경될 경우 해당 상수를 사용하는 다른 어셈블리의 빌드 시점과 달라 오류가 발생한다.
    // public 으로 지정해서 사용하게 할 때는 static readonly로 상수 선언해서 사용할 것.
    // readonly는 실행시점에 결정됨
    private const double ratio = 0.3048;

    public static double FromMeter(double meter) {
        return meter / ratio;
    }

    public static double ToMeter(double feet) {
        return feet * ratio;
    }
}
