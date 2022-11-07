import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

public class Lesson1 {


    public static void printer() {
        System.out.println("Я");
        System.out.println("хорошо");
        System.out.println("знаюJava");
        System.out.println("хорошознаюJava");
    }

    public static void accountant() {
        double first = (46 + 10) * (double) 10 / 3;
        System.out.println("(46+10) * (10/3) =  " + first);

        double second = (29) * (4) * (-15);
        System.out.println("29 * 4 * -15 = " + second);
    }

    public static void division() {
        int number = 100500;
        int result = (number / 10) / 10;
        System.out.println("(100500/10)/10 = " + result);
    }

    public static void multiplication() {
        double first = 3.6;
        double second = 4.1;
        double third = 5.9;
        double result = first * second * third;
        System.out.println("3.6 * 4.1 * 5.9 = " + result);

    }

    public static void reader() {

        List<Integer> list = new ArrayList<Integer>();
        Scanner in = new Scanner(System.in);
        boolean stopCycle = false;

        while (!stopCycle) {
            System.out.println("Введите число :");
            list.add(in.nextInt());
            System.out.println("Продолжить ввод чисел? (Y/N)");
            if ("N".equals(in.next().toUpperCase(Locale.ENGLISH))) {
                stopCycle = true;
            }
        }
        for (int i : list) {
            System.out.println(i);
        }
    }

    public static void isNumberEven() {
        boolean stopCycle = false;
        Scanner in = new Scanner(System.in);
        while (!stopCycle) {

            System.out.println("Введите число :");
            int value = in.nextInt();

            if (value > 100) {
                System.out.println("Выход за пределы диапазона");
            } else {
                if ((float) value % 2 == 0) {
                    System.out.println("Четное");
                } else {
                    System.out.println("Нечетное");
                }
            }
            System.out.println("Продолжить ввод чисел? (Y/N)");
            if ("N".equals(in.next().toUpperCase(Locale.ENGLISH))) {
                stopCycle = true;
            }
        }
    }

    public static void main(String... args) {
        printer();
        accountant();
        division();
        multiplication();
        reader();
        isNumberEven();
    }

}
