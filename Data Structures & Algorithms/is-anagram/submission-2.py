from collections import defaultdict

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        
        charmap = defaultdict(int)

        for letter in s:
            charmap[letter] += 1

        for letter in t:
            charmap[letter] -= 1
        
        for count in charmap.values():
            if count != 0:
                return False
                
        return True
            

            