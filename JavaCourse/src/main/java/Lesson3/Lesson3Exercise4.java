package Lesson3;

public class Lesson3Exercise4 {

    static class Tree {

        int age;
        boolean isAlive;
        String name;

        Tree(String treeName, int treeAge) {
            this.age = treeAge;
            this.name = treeName;
        }

        Tree(String treeName, int treeAge, boolean isAlive) {
            this.age = treeAge;
            this.name = treeName;
            this.isAlive = isAlive;
        }

        Tree() {
            System.out.println("Пустой конструктор без параметров сработал");
        }

        void getClassValues() {
            System.out.println("Name of the tree is: " + name + ". It is " + age + " ages old. " + "Is the tree alive : " + isAlive);
        }
    }

    public static void main(String... args) {
        Tree tree1 = new Tree();
        Tree tree2 = new Tree("Baobab", 1066);
        Tree tree3 = new Tree("Tree of the knowledge of good and evil", 2021, false);

        tree1.getClassValues();
        tree2.getClassValues();
        tree3.getClassValues();
    }
}
