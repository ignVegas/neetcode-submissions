public class Solution {

   private const string Marker = "\u0002"; 

    public string Encode(IList<string> strs) {
        if (strs == null || strs.Count == 0) return ""; 
        // Prepend the marker so [""] becomes "\u0002" instead of ""
        return Marker + string.Join("\u001F", strs);
    }

    public List<string> Decode(string s) {
        if (string.IsNullOrEmpty(s)) return new List<string>();
        
        // Strip the marker to process the inner strings safely
        string data = s.Substring(Marker.Length);
        return data.Split('\u001F').ToList();
    }
}
