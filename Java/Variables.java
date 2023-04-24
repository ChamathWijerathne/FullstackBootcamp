import java.util.ArrayList;
import java.util.List;

public class Variables
{
    public static void main(String [] args){
            int number = 123;
            String message = "Hello";
            List<Integer> list = new ArrayList<Integer>();
            list.add(1);
            list.add(3);
            list.add(5);
            list.remove(1);
            System.out.println(number);
            System.out.println(message);
            System.out.println("ArrayList : " + list.toString());
    }
}