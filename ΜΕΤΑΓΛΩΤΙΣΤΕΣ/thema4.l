%{
#include <stdio.h>
%}

%%
"trigono "[a-zA-Z]([a-zA-Z])([a-zA-Z]) {printf("%s valid\n", yytext);}
"tetragono "[a-zA-Z]([a-zA-Z])([a-zA-Z])([a-zA-Z]) {printf("%s valid\n", yytext);}
"pentagono "[a-zA-Z]([a-zA-Z])([a-zA-Z])([a-zA-Z])([a-zA-Z]) {printf("%s valid\n", yytext);}
"exagono "[a-zA-Z]([a-zA-Z])([a-zA-Z])([a-zA-Z])([a-zA-Z])([a-zA-Z]) {printf("%s valid\n", yytext);}
"eptagono "[a-zA-Z]([a-zA-Z])([a-zA-Z])([a-zA-Z])([a-zA-Z])([a-zA-Z])([a-zA-Z]) {printf("%s valid\n", yytext);}
"oktagono "[a-zA-Z]([a-zA-Z])([a-zA-Z])([a-zA-Z])([a-zA-Z])([a-zA-Z])([a-zA-Z])([a-zA-Z])  {printf("%s valid\n", yytext);}

. {printf("%s invalid\n", yytext);}
\n    {return 0;}
%%
 
int main() {
    yylex();
    return 0;
}

int yywrap() {
    return 1;
}
