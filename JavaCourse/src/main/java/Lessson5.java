import java.util.Locale;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Lessson5 {

  static class WordsExecution{

  void findThelongestWord(String s)
    {

      String[] res= s.split(" ");

      int longesWordLength = res[0].length();
      int longestWordindex = 0;

      for(int i = 0; i < res.length; i++){
        if(res[i].length() > longesWordLength){
          longestWordindex = i;
          longesWordLength = res[i].length();
        }
      }
      System.out.println("The longest word is: " + res[longestWordindex] + " Index is:" + longestWordindex);
    }

    void isStringAPalindrome(String s){

      String[] res= s.split(" ");
      StringBuilder sb = new StringBuilder();

      for (String item:res) {
       sb = sb.append(item);
      }

      String beforeReverse = new String(sb);
      String afterReverse = new String(sb.reverse());

      if(beforeReverse.equalsIgnoreCase(afterReverse)){
        System.out.println("This is palindrome: " + s);
      }
      else {
        System.out.println("Not a palindrome: "+ s);
      }
  }

  void censorship(String s){
    String str =s;
      str=str.replaceAll("(Б|б)(Я|я)(К|к)(А|а)", "[Вырезано цензурой]");
      System.out.println(str);
  }

  void findAllSubstrings(String originalString, String substring){

    Pattern pattern = Pattern.compile(substring.toLowerCase());
    Matcher matcher =  pattern.matcher(originalString.toLowerCase(Locale.ENGLISH));

    int count = 0;
    while (matcher.find()) {
      count++;
    }
    System.out.println("There are "+count+ " matches of word: " + substring);
  }

  void revertWords(String s){
    String[] res= s.split(" ");
    String result = "";
    for (String item:res) {
      StringBuilder sb = new StringBuilder(item);
      sb.reverse();
      result += " " + sb;
    }
    System.out.println("Original string: "+s);
    System.out.println("Result of reverse each word: " + result);
  }

  }


  public static void main(String[] args) {

    WordsExecution wordsExecution = new WordsExecution();
    wordsExecution.findThelongestWord("АБВ АБВГ АБВГД"); //
    wordsExecution.findThelongestWord("АБВГД АБВГ АБВ");
    wordsExecution.findThelongestWord("АБВ АБВ АБВ");
    wordsExecution.findThelongestWord("АБ АБ АБВ");
    wordsExecution.findThelongestWord("АБВ АБВГД АБВГ");
    System.out.println("====separator====");
    wordsExecution.isStringAPalindrome("И у облаков вокал Боуи");
    wordsExecution.isStringAPalindrome("У попа была собака");
    wordsExecution.isStringAPalindrome("арозаупаланалапуазора");
    wordsExecution.isStringAPalindrome("мыло — голым!");
    wordsExecution.isStringAPalindrome("мыло голым");
    System.out.println("====separator====");
    wordsExecution.censorship("СобакабякасобакаБяБЯкасобакаБЯКАсобака");
    wordsExecution.censorship("СкорБЯ КАк собака бяка");
    System.out.println("====separator====");
    wordsExecution.findAllSubstrings("«James, while John had had “Had”, had had ”had had”; “Had had” had had a better effect on the teacher»"
        + "— предложение на английском языке, которое используют для демонстрации возможной лексической неопределённости",
        "had");
    wordsExecution.findAllSubstrings("Well, there's egg and bacon; egg sausage and bacon; egg and spam; egg bacon and spam; "
            + "egg bacon sausage and spam; spam bacon sausage and spam; spam egg spam spam bacon and spam; "
            + "spam sausage spam spam bacon spam tomato and spam;", "spam");
    System.out.println("====separator====");
    wordsExecution.revertWords("Per aspera ad astra  = лат. \"Через тернии к звёздам\" ");
  }
}
