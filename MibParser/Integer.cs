/*
 * Created by SharpDevelop.
 * User: lextm
 * Date: 2008/7/25
 * Time: 20:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lextm.SharpSnmpLib.Mib
{
	/// <summary>
	/// The INTEGER type represents a list of alternatives..
	/// </summary>
	public sealed class Integer : ITypeAssignment
    {
        /// <summary>
        /// Creates a <see cref="Choice"/> instance.
        /// </summary>
        /// <param name="module"></param>
        /// <param name="name"></param>
        /// <param name="lexer"></param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "module")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name")]
        public Integer(string module, string name, Lexer lexer)
        {
            Symbol temp = lexer.GetNextNonEOLSymbol();
            if (temp == Symbol.OpenBracket)
            {
                while ((temp = lexer.GetNextSymbol()) != Symbol.CloseBracket)
                {
                }     
                
                return;
            }
            
            if (temp == Symbol.OpenParentheses) 
            {
                while ((temp = lexer.GetNextSymbol()) != Symbol.CloseParentheses)
                {
                }  
                
                return;
            }

            //lexer.Restore(temp); 
            //lexer.Parse(temp);
        }
    }
}