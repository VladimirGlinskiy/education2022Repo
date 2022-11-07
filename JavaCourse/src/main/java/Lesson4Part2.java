import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class Lesson4Part2 {

    public static void isArraySorted(int[] array) {

        boolean result = false;
        for (int i = 1; i < array.length; i++) {
            result = array[i - 1] < array[i];
        }
        if (result) {
            System.out.println("OK");
        } else {
            System.out.println("Please, try again");
        }
    }

    public static void arrayGenerator() {
        Scanner in = new Scanner(System.in);
        System.out.println("Введите длину массива :");

        int length = in.nextInt();
        Integer[] array = new Integer[length];
        for (int i = 0; i < length; i++) {
            System.out.println("Введите значение массива :");
            array[i] = in.nextInt();
        }

        System.out.println("Array length: " + length);
        System.out.println("Numbers of array: ");
        for (int i : array) {
            System.out.println(i);
        }
        System.out.println("Result: " + Arrays.toString(array));

    }

    public static void changer(int[] array) {
        int firstValue = array[0];
        int leastValue = array[array.length - 1];
        System.out.println(Arrays.toString(array));

        array[0] = leastValue;
        array[array.length - 1] = firstValue;
        System.out.println(Arrays.toString(array));
    }

    public static void findUniqueNumber(int[] array) {

        List<Integer> duplicates = new ArrayList<Integer>();

        for (int i = 0; i <= array.length - 1; i++) {
            int nextNumber = array[i];

            if (!duplicates.contains(
                    nextNumber)) { //экстра-проверка для того, чтобы убрать лишние проходы по массиву

                for (int j = i + 1; j < array.length - 1; j++) {
                    if (array[j] == nextNumber) {
                        duplicates.add(array[j]);
                        break;
                    }
                }

                if (!duplicates.contains(nextNumber)) {
                    System.out.println(
                            "Первое уникальное число массива " + Arrays.toString(array) + " это число "
                                    + array[i]);
                    break;
                }
            }
        }
    }

    public static int[] mergeSort(int[] array) {

        System.out.println("Original array: " + Arrays.toString(array));
        //Если в массиве только одно число, то менять нечего. Возвращаем массив из одного числа
        if (array.length < 2) {
            return array;
        }

        int middle = array.length / 2;
        int[] left = new int[middle];
        int[] right;

        //Проверяем четная ли длина массива
        if (array.length % 2 == 0) {
            right = new int[middle];
        } else {
            right = new int[middle + 1];
        }

        //Переписываем в левый массив данные из оригинального массива
        for (int i = 0; i < left.length; i++) {
            left[i] = array[i];
        }

        //Переписываем в правый массив данные из оригинального массива
        for (int j = 0; j < right.length; j++) {
            right[j] = array[middle + j];
        }

        //Рекурсивный вызов метода с передачей ему разделенной части
        left = mergeSort(left);
        right = mergeSort(right);

        return mergeParts(left, right);
    }

    private static int[] mergeParts(int[] left, int[] right) {
        int[] result = new int[left.length + right.length];

        int leftPointer = 0;
        int rightPointer = 0;
        int resultPointer = 0;

        while (leftPointer < left.length || rightPointer < right.length) {
            if (leftPointer < left.length && rightPointer < right.length) {
                if (left[leftPointer] < right[rightPointer]) { //Сравнение чисел
                    result[resultPointer++] = left[leftPointer++]; //Добавляем в результирующий массив значение
                } else {
                    result[resultPointer++] = right[rightPointer++];
                }
                //Добавляем оставшееся число
            } else if (leftPointer < left.length) {
                result[resultPointer++] = left[leftPointer++];
            } else if (rightPointer < right.length) {
                result[resultPointer++] = right[rightPointer++];
            }
        }
        System.out.println("Result: " + Arrays.toString(result));
        return result;
    }


    public static void main(String[] args) {
        isArraySorted(new int[]{1, 1, 1});
        isArraySorted(new int[]{0, 1, 0});
        isArraySorted(new int[]{0, 0, 1});
        isArraySorted(new int[]{0, 1, 1, 0});
        isArraySorted(new int[]{-1, 0, 1, 2});
        System.out.println("--separator--");
        arrayGenerator();
        System.out.println("--separator--");
        changer(new int[]{1, 3, 4, 5});
        System.out.println("--separator--");
        findUniqueNumber(new int[]{1, 1, 3, 5, 3, 3, 3});
        findUniqueNumber(new int[]{1, 1, 3, 5, 3, 3, 3, 6});
        findUniqueNumber(new int[]{1, 1, 3, 5, 3, 3, 5, 6});
        System.out.println("--separator--");
        mergeSort(new int[]{3, 1});
        mergeSort(new int[]{3, 1, 4, 2});
        mergeSort(new int[]{3, 1, 4, 2, 432, 43253, 43, 4232, 132, 32, 3, 2, 21});
    }
}
