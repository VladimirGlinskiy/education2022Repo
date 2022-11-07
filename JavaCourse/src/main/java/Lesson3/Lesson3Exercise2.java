package Lesson3;


import javax.sound.midi.Soundbank;

class Lesson3Exercise2 {

    static class Car {

        String color;
        String name;
        int weight;

        Car(String color, String name, int weight) {
            this.color = color;
            this.weight = weight;
            this.name = name;
        }

        Car(String color) {
            this.color = color;
        }

        Car(String color, int weight) {
            this.color = color;
            this.weight = weight;
        }

        Car() {
        }

        public static void main(String... args) {

            Car car1 = new Car("Red", "Ferrari", 2000);
            Car car2 = new Car("White", "Audi", 2500);

            car1.printer();
            car2.printer();
        }

        void printer() {
            System.out.println("Color: " + color + ", Name: " + name + ", Weight: " + weight);
        }
    }

}
