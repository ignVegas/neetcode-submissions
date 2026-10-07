class Solution:
    def maxArea(self, heights: List[int]) -> int:
        max_area = 0
        left = 0
        right = len(heights) - 1
        while right > left:
            height = min(heights[left], heights[right])
            width = right - left
            currArea = width * height
            if currArea > max_area:
                max_area = currArea

            if heights[left] > heights[right]:
                right -= 1
            else:
                left += 1

        return max_area
        