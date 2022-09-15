using System.Collections.Generic;

class Program {
     public static void Main(string[] args) {
        User[] users = InputUsers();

        PrintUsersInformation(users);
    }

    public static User[] InputUsers() {
        User[] users = new User[8];

        for(int index = 0; index < users.Length; index++) {
            Console.WriteLine("******** Input User Number: {0} ********", index + 1);

            User user = new User(InputName(),
            InputSurname(),
            InputStudentID(),
            InputScore());

            users[index] = user;

            Console.WriteLine("****************************************");
            Console.WriteLine();
        }

        return users;
    }

    public static void PrintUsersInformation(User[] users) {
       Array.ForEach(users, user => Console.WriteLine(user.PrintUserInformation()));
    }

    public static string InputName() {
        Console.Write("Input Name: ");

        return Console.ReadLine();
    }

    public static int InputScore() {
        Console.Write("Input Score: ");
        string scoreText = Console.ReadLine();

          if (int.TryParse(scoreText, out int number)) {
            return number;
         }

       throw new Exception("Please input decimal data."); 
    }

    public static string InputStudentID() {
        Console.Write("Input StudentID: ");

        return Console.ReadLine();
    }

    public static string InputSurname() {
        Console.Write("input Surname:");

        return Console.ReadLine();
    }
}
public class User {
    public string name;
    public string surname;
    public string studentID;
    private Grade gradeInformation;

    public User(string name, string surname, string studentID, int score) {
        this.name = name;
        this.surname = surname;
        this.studentID = studentID;
        this.gradeInformation = new Grade(score);
    }

    public string PrintGrade() {
        return this.gradeInformation.ShowGrade();
    }

    public int PrintScore() {
        return this.gradeInformation.ShowScore();
    }

    public string PrintUserInformation() {
        return "User information is : " 
        + this.name + " " + this.surname + " " +
         this.studentID + " Score is: " +
         this.gradeInformation.ShowScore() + " Grade is:" +
         this.gradeInformation.ShowGrade();
    }
}
public class Grade {
    private int score;
    private string grade;

    public Grade(int score) {
        this.score = score;
        this.grade = ConvertScoreToGrade(score);
    }

    public string ShowGrade() {
        return this.grade;
    }

    public int ShowScore() {
        return this.score;
    }

    public string ConvertScoreToGrade(int score) {
        if (score > 100) { 
            throw new Exception("Please input data 0 - 100"); }

        if (IsGradeA(score)) {
            return "Grade A";
        } else if (IsGradeBPlus(score)) {
            return "Grade B+";
        } else if (IsGradeB(score)) {
            return "Grade B";
        } else if (IsGradeCPlus(score)) {
            return "Grade C+";
        } else if (IsGradeC(score)) {
            return "Grade C";
        } else if (IsGradeDPlus(score)) {
            return "Grade D+";
        } else if (IsGradeD(score)) {
            return "Grade D";
        } else if (IsGradeF(score)){
            return "Grade F";
        } else {
              throw new Exception("Please input data 0 - 100");
        }
    }

    public bool IsGradeA(int score) {
        return score <= 100 && score >= 80;
    }

    public bool IsGradeBPlus(int score) {
        return score < 80 && score >= 75;
    }

    public  bool  IsGradeB(int score) {
        return score < 75 && score >= 70;
    }

    public bool IsGradeCPlus(int score) {
        return score < 70 && score >= 65;
    }

    public bool IsGradeC(int score) {
        return score < 65 && score >= 60;
    }

    public bool IsGradeDPlus(int score) {
        return score < 60 && score >= 55;
    }

    public bool IsGradeD(int score) {
        return score <= 54 && score >= 50;
    }

    public bool IsGradeF(int score) {
        return score < 50 && score >= 0;
    }

}