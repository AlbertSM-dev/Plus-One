public class Solution {
    public int[] PlusOne(int[] digits) {
        var sum = BigInteger.Parse(string.Concat(digits));
        sum++;
        var str = sum.ToString();
        List<int> listSum = new List<int>();
        
        for (var i = 0; i < str.Length; i++) {
            listSum.Add((int)Char.GetNumericValue(str[i]));            
        }
    
        return listSum.ToArray();
    }
}
