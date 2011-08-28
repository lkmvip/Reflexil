﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

// this file was autogenerated by a tool.
using System;

namespace ICSharpCode.NRefactory.Parser.VB
{
	public static class Keywords
	{
		static readonly string[] keywordList = {
			"ADDHANDLER",
			"ADDRESSOF",
			"AGGREGATE",
			"ALIAS",
			"AND",
			"ANDALSO",
			"ANSI",
			"AS",
			"ASCENDING",
			"ASSEMBLY",
			"AUTO",
			"BINARY",
			"BOOLEAN",
			"BYREF",
			"BY",
			"BYTE",
			"BYVAL",
			"CALL",
			"CASE",
			"CATCH",
			"CBOOL",
			"CBYTE",
			"CCHAR",
			"CDATE",
			"CDBL",
			"CDEC",
			"CHAR",
			"CINT",
			"CLASS",
			"CLNG",
			"COBJ",
			"COMPARE",
			"CONST",
			"CONTINUE",
			"CSBYTE",
			"CSHORT",
			"CSNG",
			"CSTR",
			"CTYPE",
			"CUINT",
			"CULNG",
			"CUSHORT",
			"CUSTOM",
			"DATE",
			"DECIMAL",
			"DECLARE",
			"DEFAULT",
			"DELEGATE",
			"DESCENDING",
			"DIM",
			"DIRECTCAST",
			"DISTINCT",
			"DO",
			"DOUBLE",
			"EACH",
			"ELSE",
			"ELSEIF",
			"END",
			"ENDIF",
			"ENUM",
			"EQUALS",
			"ERASE",
			"ERROR",
			"EVENT",
			"EXIT",
			"EXPLICIT",
			"FALSE",
			"FINALLY",
			"FOR",
			"FRIEND",
			"FROM",
			"FUNCTION",
			"GET",
			"GETTYPE",
			"GLOBAL",
			"GOSUB",
			"GOTO",
			"GROUP",
			"HANDLES",
			"IF",
			"IMPLEMENTS",
			"IMPORTS",
			"IN",
			"INFER",
			"INHERITS",
			"INTEGER",
			"INTERFACE",
			"INTO",
			"IS",
			"ISNOT",
			"JOIN",
			"KEY",
			"LET",
			"LIB",
			"LIKE",
			"LONG",
			"LOOP",
			"ME",
			"MOD",
			"MODULE",
			"MUSTINHERIT",
			"MUSTOVERRIDE",
			"MYBASE",
			"MYCLASS",
			"NAMESPACE",
			"NARROWING",
			"NEW",
			"NEXT",
			"NOT",
			"NOTHING",
			"NOTINHERITABLE",
			"NOTOVERRIDABLE",
			"OBJECT",
			"OF",
			"OFF",
			"ON",
			"OPERATOR",
			"OPTION",
			"OPTIONAL",
			"OR",
			"ORDER",
			"ORELSE",
			"OUT",
			"OVERLOADS",
			"OVERRIDABLE",
			"OVERRIDES",
			"PARAMARRAY",
			"PARTIAL",
			"PRESERVE",
			"PRIVATE",
			"PROPERTY",
			"PROTECTED",
			"PUBLIC",
			"RAISEEVENT",
			"READONLY",
			"REDIM",
			"REM",
			"REMOVEHANDLER",
			"RESUME",
			"RETURN",
			"SBYTE",
			"SELECT",
			"SET",
			"SHADOWS",
			"SHARED",
			"SHORT",
			"SINGLE",
			"SKIP",
			"STATIC",
			"STEP",
			"STOP",
			"STRICT",
			"STRING",
			"STRUCTURE",
			"SUB",
			"SYNCLOCK",
			"TAKE",
			"TEXT",
			"THEN",
			"THROW",
			"TO",
			"TRUE",
			"TRY",
			"TRYCAST",
			"TYPEOF",
			"UINTEGER",
			"ULONG",
			"UNICODE",
			"UNTIL",
			"USHORT",
			"USING",
			"VARIANT",
			"WEND",
			"WHEN",
			"WHERE",
			"WHILE",
			"WIDENING",
			"WITH",
			"WITHEVENTS",
			"WRITEONLY",
			"XOR",
			"GETXMLNAMESPACE"
		};
		
		static LookupTable keywords = new LookupTable(false);
		
		static Keywords()
		{
			for (int i = 0; i < keywordList.Length; ++i) {
				keywords[keywordList[i]] = i + Tokens.AddHandler;
			}
		}
		
		public static int GetToken(string keyword)
		{
			return keywords[keyword];
		}
		
		public static bool IsNonIdentifierKeyword(string word)
		{
			int token = GetToken(word);
			if (token < 0)
				return false;
			return !Tokens.IdentifierTokens[token];
		}
	}
}
