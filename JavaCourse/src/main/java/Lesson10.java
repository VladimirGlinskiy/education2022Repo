import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.Writer;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;




public class Lesson10 {

  private static final String ROOT = "src/main/java/TextFiles/";

  static List<String> readFile(String path) {
    List<String> list = new ArrayList<>();
    File file = new File(path);

    try (BufferedReader reader = new BufferedReader(new FileReader(file))) {
      String input;
      while ((input = reader.readLine()) != null) {
        list.add(input);
      }
    } catch (IOException e) {
      System.out.println(e.getMessage());
    }
    System.out.println(list);
    return list;
  }


  static void writeFile(String string, String filePath) {

    Writer writer = null;

    try {
      File outputFile = new File(filePath);
      writer = new FileWriter(outputFile);
      writer.write(string);
    } catch (IOException e) {
      System.out.println(e.getMessage());
    } finally {
      if (writer != null) {
        try {
          writer.close();
        } catch (IOException e) {
          System.out.println(e.getMessage());
        }
      }
    }
  }

  static void mergeFiles(File firstFile, File secondFile) {

    List<File> files = Arrays.asList(firstFile, secondFile);
    File outputFile = new File(
            ROOT+"exercise3.txt");

    String text = "";

    for (File file : files) {
      for (String str : readFile(file.getPath())) {
        text += str;
        text += "\n";
      }
    }
    System.out.println(text);

    writeFile(text, outputFile.getPath());
  }

  static void replaceСharacters(File file) {
    List<String> list = new ArrayList<>();
    String input;

    try (BufferedReader reader = new BufferedReader(new FileReader(file))) {

      while ((input = reader.readLine()) != null) {
        System.out.println(input);
        input = input.replaceAll("[^a-zA-Zа-яА-Я0-9]", "\\$");

        list.add(input);
      }

      System.out.println(list);

      FileWriter writer = new FileWriter(
              ROOT+"exercise4.result.txt");
      for (String str : list) {
        writer.write(str + System.lineSeparator());
      }

      writer.close();

    } catch (IOException e) {
      System.err.println(e.getMessage());
    }

  }


  public static void main(String[] args) {
    //Задание 1

    readFile(ROOT+"exercise1.txt");

    //Задание 2
    writeFile("Текстовая строка",
            ROOT+"exercise2.txt");

    //Задание 3
    File file1 = new File(
            ROOT+"exercise1.txt");
    File file2 = new File(
            ROOT+"exercise2.txt");
    mergeFiles(file2, file1);


    //Задание 4
    File file3 = new File(
            ROOT+"exercise4.txt");
    replaceСharacters(file3);
  }

}


