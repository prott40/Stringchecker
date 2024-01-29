/* ParenthesisMatcher.cs
 * Author:
 */
namespace Ksu.Cis300.Parentheses
{
    /// <summary>
    /// Contains code for detecting balanced parentheses.
    /// </summary>
    public static class ParenthesisMatcher
    {
        /// <summary>
        /// Determines whether the given string contains matched parentheses.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>Whether the string is balanced.</returns>
        public static bool IsBalanced(string s)
        {
            Stack<char> st = new Stack<char>();
            
            foreach (char c in s)
            {   
                if (IsOpeningParenthesis(c))
                {
                    st.Push(c);
                }
                else if (IsClosingParenthesis(c))
                {
                    if((st.Count > 0)&& Matches(st.Peek(),c))
                    {
                        st.Pop();
                    }
                    else
                    {
                        return false;
                    }
                    
                }
                
            }
            if(st.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        /// <summary>
        /// Determines whether the given character is an opening parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is an opening parenthesis.</returns>
        private static bool IsOpeningParenthesis(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        /// <summary>
        /// Determines whether the given character is a closing parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is a closing parenthesis.</returns>
        private static bool IsClosingParenthesis(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        /// <summary>
        /// Determines whether the given characters form a matched pair
        /// of parentheses.
        /// </summary>
        /// <param name="a">The opening character.</param>
        /// <param name="b">The closing character.</param>
        /// <returns>Whether a and b form a matched pair of parentheses.</returns>
        private static bool Matches(char a, char b)
        {
            return (a == '(' && b == ')') || (a == '[' && b == ']') ||
                (a == '{' && b == '}');
        }

    }
}