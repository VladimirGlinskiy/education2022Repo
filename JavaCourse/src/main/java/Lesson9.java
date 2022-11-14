import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.time.Duration;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.Set;

public class Lesson9 {

  static class User {

    private String name;

    public String getName() {
      return name;
    }

    public void setName(String name) {
      this.name = name;
    }
  }


  Map<User, Integer> userScoreGeteratior() {

    Map<User, Integer> map = new HashMap<>();
    for (int i = 0; i < 10; i++) {
      User user = new User();
      user.setName("User" + i); // Имя пользователя будет в диапазоне User1, User2 ... User10

      Double score = Math.random();
      map.put(user, score.intValue());

    }
    return map;
  }

  static Set<String> getUniqueCollection(List<String> list) {
    Set<String> set = new HashSet<>(list);
    System.out.println(set);
    return set;
  }

  static List<Integer> getArraylist() {

    List<Integer> list = new ArrayList<>();

    for (int i = 0; i < 1000000; i++) {

      Double randDoubleValue = Math.random();
      list.add(randDoubleValue.intValue());

    }
    return list;
  }

  static List<Integer> getLinkedlist() {

    List<Integer> list = new LinkedList<>();

    for (int i = 0; i < 1000000; i++) {

      Double randDoubleValue = Math.random();
      list.add(randDoubleValue.intValue());

    }
    return list;
  }

  static void compareCollections(List<Integer> arrayList, List<Integer> linkedList) {

    LocalDateTime arrayListStartCycle = LocalDateTime.now();

    for (int i = 0; i < 100000; i++) {
      Double doubleValue = Math.random();
      arrayList.get(doubleValue.intValue());
    }

    LocalDateTime arrayListEndCycle = LocalDateTime.now();

    Duration arrayListDuration = Duration.between(arrayListStartCycle, arrayListEndCycle);
    System.out.println("Время для arrayList:  " + arrayListDuration.getNano() + " наносекунд.");

    LocalDateTime linkedListStartCycle = LocalDateTime.now();

    for (int i = 0; i < 100000; i++) {
      Double doubleValue = Math.random();
      linkedList.get(doubleValue.intValue());
    }

    LocalDateTime linkedListEndCycle = LocalDateTime.now();

    Duration linkedListDuration = Duration.between(linkedListStartCycle, linkedListEndCycle);
    System.out.println("Время для linkedList: " + linkedListDuration.getNano() + " наносекунд.");

  }

  static String reader() throws IOException {
    BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    return br.readLine();
  }

  static void getUserScore(Map<User, Integer> map) throws IOException {
    System.out.println("Введите имя пользователя: ");
    String name = reader();
    for (Map.Entry<User, Integer> instance : map.entrySet()) {
      String key = instance.getKey().getName();
      if (key.equals(name)) {
        System.out.println("Пользователь набрал " + instance.getValue() + " очков.");
      }
    }
  }

  public static void main(String[] args) throws IOException {

    //Упражнение 1
    List<String> list = new ArrayList<>();

    list.add("Никулин");
    list.add("Моргунов");
    list.add("Вицин");
    list.add("Моргунов");
    list.add("Моргунов");
    list.add("Моргунов");
    list.add("Вицин");
    list.add("Вицин");
    list.add("Никулин");

    getUniqueCollection(list);

    //Упражнение 2
    compareCollections(getArraylist(), getLinkedlist());

    //Упражнение 3
    Map<User, Integer> map = new HashMap<>();

    for (int i = 1; i <= 10; i++) {
      User user = new User();
      user.setName("User" + i);

      Double score = Math.random() * 100;
      map.put(user, score.intValue());
    }

    getUserScore(map);
  }
}
