using csharp.Models;

namespace c__test
{
	public class ExtensionsTest
	{
		[Fact]
		public void IsPalindrome_WithPalindrome_ReturnsTrue()
		{
			string input = "racecar";

			bool result = input.IsPalindrome();

			Assert.True(result);
		}

		[Fact]
		public void IsPalindrome_WithNonPalindrome_ReturnsFalse()
		{
			string input = "hello";

			bool result = input.IsPalindrome();

			Assert.False(result);
		}
	}
}