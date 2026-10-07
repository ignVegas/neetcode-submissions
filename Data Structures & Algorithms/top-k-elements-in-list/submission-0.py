class Solution:
    from collections import Counter
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        counts = Counter(nums)

        top_k = [item for item, count in counts.most_common(k)]

        return top_k
        