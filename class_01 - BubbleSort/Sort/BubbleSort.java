
package Sort;

/**
 * Fortune University Class_DataStructurs 1 _1 BubbleSort
 * student: MacTaylor(游崇祐)
 * date: 2014/10/21
 * teacher: Pei-Wei Tsai (蔡沛緯)
 * Reference: https://www.youtube.com/watch?v=kPRA0W1kECg&index=68&list=LLKpbtaPY2aYpQjbwaIq7-hw
 */
public class BubbleSort {
/**
* Bubble sort method statement
*
* @method process
* @param data array, can use next iterator
*/
    
    public int[] process(int data[]){
    /**
        * process
        * @method process
        * @param [ array length -1](n-1), compare n*(n-1)/2
        **/  int tmp;
        for (int i = 0; i < (data.length - 1 ); i++) {
            for (int j = 0; j < data.length - i - 1; j++) {
                if (data[j] > data[j+1]) {
                    tmp = data[j];
                    data[j] = data[j+1];
                    data[j+1] = tmp;
              }
            }
        }
        return data;
    }
}