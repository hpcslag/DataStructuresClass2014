
package Search;

/**
 * Fortune University Class_DataStructurs 1 _2 BinarySearch
 * student: MacTaylor(游崇祐)
 * date: 2014/11/3
 * teacher: Pei-Wei Tsai (蔡沛緯)
 * Reference: Books of  Java Program Algorithm Focus 2009
 */
public class BinarySearch {
    /**
        * process
        * @method process
        * @param [ array number](n-1), des
        **/
    public int process(int[] number, int des) {
        int low = 0; 
        int upper = number.length - 1; 

        while(low <= upper) { 
            int mid = (low+upper) / 2; 
            if(number[mid] < des){ 
                low = mid+1; 
            }else if(number[mid] > des){ 
                upper = mid - 1; 
            }else{ 
                return mid; 
            }
        } 
        return -1; 
    }
}
