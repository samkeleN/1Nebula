// Back-End Code Callenge
// Samkele Ndzululeka
// Question 1

import java.util.List;

public class LikeSystem {
    public static void main(String[] args) {
        //System.out.println();
        System.out.println(Likes(List.of()));
        System.out.println(Likes(List.of("Peter")));
        System.out.println(Likes(List.of("Jacob", "Alex")));
        System.out.println(Likes(List.of("Max", "John", "Mark")));
        System.out.println(Likes(List.of("Alex", "Jacob", "Mark", "Max")));
    }

    public static String Likes(List<String> names) {
        int count = names.size();
        switch (count) {
            case 0:
                return "No one likes this";
            case 1:
                return names.get(0) + " likes this";
            case 2:
                return names.get(0) + " and " + names.get(1) + " like this";
            case 3:
                return names.get(0) + ", " + names.get(1) + " and " + names.get(2) + " like this";
            default:
                return names.get(0) + ", " + names.get(1) + " and " + (count - 2) + " others like this";
        }
    }
}