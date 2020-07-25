import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split(" ");

        int L = Integer.parseInt(input[0]);
        int x = Integer.parseInt(input[1]);

        int notEnter = 0;
        int persons = 0;

        while (x-- > 0) {
            
            String[] activity = scanner.nextLine().split(" ");
            var event = plusOrMinus(activity[0], Integer.parseInt(activity[1]));
            persons += event;

            if(persons > L){
                notEnter++;
                persons -= event;
            }
        }

        System.out.println(notEnter);

    }

    public static int plusOrMinus(String str, int nr){
        if(str.toLowerCase().equals("enter")){
             nr = nr;
        } else if(str.toLowerCase().equals("leave")){
            nr = -Math.abs(nr);
        }
        return nr;
    }
}
