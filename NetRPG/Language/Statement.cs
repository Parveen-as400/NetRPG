﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetRPG.Language
{
    class Statement
    {
        public List<RPGToken> _Tokens;

        public Statement(List<RPGToken> Tokens)
        {
            _Tokens = Tokens;
        }

        public RPGToken[] GetTokens() => _Tokens.ToArray();

        public static Statement[] ParseDocument(List<RPGToken> Tokens)
        {
            List<Statement> Statements = new List<Statement>();
            List<RPGToken> CurrentStatement = new List<RPGToken>();

            foreach (RPGToken token in Tokens)
            {
                if (token.Type == RPGLex.Type.STMT_END)
                {
                    Statements.Add(new Statement(CurrentStatement));
                    CurrentStatement = new List<RPGToken>();
                }
                else
                {
                    CurrentStatement.Add(token);
                }
            }

            return Statements.ToArray();
        }

        public static Statement[] ParseParams(List<RPGToken> Tokens)
        {
            List<Statement> Statements = new List<Statement>();
            List<RPGToken> CurrentStatement = new List<RPGToken>();

            foreach (RPGToken token in Tokens)
            {
                if (token.Type == RPGLex.Type.PARMS)
                {
                    Statements.Add(new Statement(CurrentStatement));
                    CurrentStatement = new List<RPGToken>();
                }
                else
                {
                    CurrentStatement.Add(token);
                }
            }

            if (CurrentStatement.Count > 0)
                Statements.Add(new Statement(CurrentStatement));

            return Statements.ToArray();
        }
    }
}
