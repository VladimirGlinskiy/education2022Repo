package Lesson3;

import java.time.LocalDateTime;

public class Lesson3exercise3 {

    static class House {

        int numberOfStories;
        LocalDateTime dateOfConstruction;
        String name;

        public void setValues(int numberOfStories, String dateOfConstruction, String name) {
            this.numberOfStories = numberOfStories;
            this.dateOfConstruction = LocalDateTime.parse(dateOfConstruction);

            this.name = name;
        }

        public void printValues() {
            System.out.println(
                    "NumberOfStories: " + numberOfStories + "\nDateOfConstruction: " + dateOfConstruction
                            + "\nName: " + name);
        }

        public void printAgeOfAHouse() {
            long agesDifference
                    = LocalDateTime.now().getYear() - dateOfConstruction.getYear();
            System.out.println("AgesDifference: " + agesDifference);
        }
    }

    public static void main(String... args) {
        House house1 = new House();
        house1.setValues(13, "1970-01-01T00:00:00", "Дом который построил Джек");
        house1.printValues();
        house1.printAgeOfAHouse();


        House house2 = new House();
        house2.setValues(678, "0006-01-01T00:00:00", "Дом который построил один Грек");
        house2.printValues();
        house2.printAgeOfAHouse();
    }

}
