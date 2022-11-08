package Lesson3;


class Study {

    private String course;

    Study(String courseName) {
        this.course = courseName;
    }

    public void printCourse() {
        System.out.println(this.course);
    }
}

class JavaProgram {

    public static void main(String[] args) {
        Study study = new Study("Изучение Java - это просто!");
        study.printCourse();
    }
}


