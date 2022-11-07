
class Lesson4Part1 {


    public static void oddNumbersPrinter() {
        System.out.println("Odd numbers printer");
        for (double i = 0; i < 100; i++) {
            if (i % 2 != 0) {
                System.out.println(i);
            }
        }
    }

    public static void getNubmersThatAreDivisibleByThreeAndFive() {
        for (double i = 1; i < 100; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                System.out.println("Делится на 3 и на 5: " + i);
            } else if (i % 3 == 0) {
                System.out.println("Делится на 3: " + i);
            } else if (i % 5 == 0) {
                System.out.println("Делится на 5: " + i);
            }
        }
    }


    public static void isSumOfNimbersIsThirdNumber(int a, int b, int c) {
        boolean result = a + b == c;
        System.out.println(result);
    }

    public static void areNumbersInProperRange(int a, int b, int c) {
        boolean result = a < b & b < c;
        if (result) {
            System.out.println(result);
            System.out.println(String.format("Numbers: %s, %s, %s", a, b, c));
        }
    }

    public static void isThreeIsFirstOrLeastNumberInArrow(int... i) {
        boolean result = false;
        if (i[0] == 3 || i[i.length - 1] == 3) {
            result = true;
        }

        String array = "";
        int counter = 0;

        for (int a : i) {
            array += a;
            counter++;

            if (counter != i.length) {
                array += ", ";
            }
        }

        System.out.println("array = " + array);
        System.out.println(result);
    }

    public static void isArrayIncludesThreeOrOne(int... i) {

        boolean result = false;
        for (int a : i) {
            if (a == 3 || a == 5) {
                result = true;
            }
        }

        if (result) {
            System.out.println("Массив содержит число 1 или 3");
        } else {
            System.out.println("Массив не содержит ни число 1, ни число 3");
        }
    }

    public static void main(String[] args) {
        oddNumbersPrinter();
        System.out.println("--separator--");
        getNubmersThatAreDivisibleByThreeAndFive();
        System.out.println("--separator--");
        isSumOfNimbersIsThirdNumber(1, 1, 2);
        isSumOfNimbersIsThirdNumber(3, 3, 5);
        isSumOfNimbersIsThirdNumber(0, 0, 0);
        System.out.println("--separator--");
        areNumbersInProperRange(1, 3, 5);
        areNumbersInProperRange(5, 3, 1);
        areNumbersInProperRange(0, 0, 1);
        areNumbersInProperRange(0, 1, 0);
        areNumbersInProperRange(1, 0, 0);
        System.out.println("--separator--");
        isThreeIsFirstOrLeastNumberInArrow(2, 3, 4);
        isThreeIsFirstOrLeastNumberInArrow(3, 3, 4);
        isThreeIsFirstOrLeastNumberInArrow(0, 1, 3);
        isThreeIsFirstOrLeastNumberInArrow(3, 0, 3);
        isThreeIsFirstOrLeastNumberInArrow(1, 0, 0);
        isThreeIsFirstOrLeastNumberInArrow(-3, 0, 0);
        System.out.println("--separator--");
        isArrayIncludesThreeOrOne(1, 2, 3);
        isArrayIncludesThreeOrOne(1, 2, 2);
        isArrayIncludesThreeOrOne(2, 0, 1);
        isArrayIncludesThreeOrOne(0, 0, 3);
        isArrayIncludesThreeOrOne(0, 3, 0);
    }

}
