
import Sort.BubbleSort;

/**
 * Fortune University Class_DataStructurs 1 _1 BubbleSort Run Demo
 * student: MacTaylor(游崇祐)
 * date: 2014/10/21
 * teacher: Pei-Wei Tsai (蔡沛緯)
 * Reference: https://www.youtube.com/watch?v=kPRA0W1kECg&index=68&list=LLKpbtaPY2aYpQjbwaIq7-hw
 */
public class Main {

    /**
         * @param args the command line arguments
        */
    public static void main(String[] args) {
        BubbleSort bs = new BubbleSort();
        int arr[] = new int[]{500,6,1,120,3,5,2,1,2};//demo array
        arr = bs.process(arr);
        for(int iterator:arr){
            System.out.println(iterator);
        }
    }
    
}
