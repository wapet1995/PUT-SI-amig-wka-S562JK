:- use_module(library(clpfd)).

zadanie_TEST():-
	X1 = [A1,A2,A3,A4,A5],
	X2 = [B1,B2,B3,B4,B5],
	X3 = [C1,C2,C3,C4,C5],
	X4 = [D1,D2,D3,D4,D5],
	X5 = [E1,E2,E3,E4,E5],
	X6 = [F1,F2,F3,F4,F5],

/* Ograniczenia podstawowe */	
	X1 ins 1..5,
	all_different(X1),
	X2 ins 1..5,
	all_different(X2),
	X3 ins 1..5,
	all_different(X3),
	X4 ins 1..5,
	all_different(X4),
	X5 ins 1..5,
	all_different(X5),
	X6 ins 1..5,
	all_different(X6),
	
/*********zdanie 1*********/
	A1 in 1..2 \/ 4..5,
	D1 in 1..2 \/ 4..5,
	F1 in 1 \/ 3..4,
	B2 in 1..2 \/ 4..5,
	C3 in 1..2 \/ 4..5,
	E2 in 1..2 \/ 4..5,
	E5 in 1..2 \/ 4..5,
	B5 in 1..2 \/ 4..5,
	
/*********zdanie 2*********/
	E1 in 1..3 \/5,
	
/*********zdanie 3*********/
	B5 in 4 \/ 5,
	
/*********zdanie 4*********/
	E5 #< 5,
	B5 #< 5,
	C1 #> B5,  
	
/*********zdanie 5*********/
	A2 #< B2,
	F2 #\= 2,
	B2 #\= 1,
	
/*********zdanie 6*********/
	A4 #> 1,
	D4 in 1..2 \/ 4..5,
	C3 #< A4,
	
/*********zdanie 7*********/
	A1 #= 4 #\/ A2 #= 4,
	A1 #= 4 #<==> F2 #= 4,
	A2 #= 4 #<==> F1 #= 4,
	
/*********zdanie 8*********/
	D3 #= 1,
	D1 #\= 1,
	D2 #\= 1,
	D4 #\= 1,
	D5 #\= 1,
	
/*********zdanie 9*********/
	A5 #\= 2,
	
/*********zdanie 10********/
	E4 #= 5,
	E1 #\= 5,
	E2 #\= 5,
	E3 #\= 5,
	E5 #\= 5,
	B4 #= C5,
	
   /* Powiazania pomiedzy tabelami */
/*-------------------------------------*/

	nth1(D1,[C1,C2,C3,C4,C5],A1),
	nth1(D2,[C1,C2,C3,C4,C5],A2),
	nth1(D3,[C1,C2,C3,C4,C5],A3),
	nth1(D4,[C1,C2,C3,C4,C5],A4),
	nth1(D5,[C1,C2,C3,C4,C5],A5),

/******************************/

	nth1(F1,[B1,B2,B3,B4,B5],A1),
	nth1(F2,[B1,B2,B3,B4,B5],A2),
	nth1(F3,[B1,B2,B3,B4,B5],A3),
	nth1(F4,[B1,B2,B3,B4,B5],A4),
	nth1(F5,[B1,B2,B3,B4,B5],A5),

/******************************/

	nth1(E1,[B1,B2,B3,B4,B5],C1),
	nth1(E2,[B1,B2,B3,B4,B5],C2),
	nth1(E3,[B1,B2,B3,B4,B5],C3),
	nth1(E4,[B1,B2,B3,B4,B5],C4),
	nth1(E5,[B1,B2,B3,B4,B5],C5),

/*-------------------------------------*/

	nth1(D1buf,[A1,A2,A3,A4,A5],C1),
	nth1(D1buf,[D1,D2,D3,D4,D5],1),
	
	nth1(D2buf,[A1,A2,A3,A4,A5],C2),
	nth1(D2buf,[D1,D2,D3,D4,D5],2),
	
	nth1(D3buf,[A1,A2,A3,A4,A5],C3),
	nth1(D3buf,[D1,D2,D3,D4,D5],3),
	
	nth1(D4buf,[A1,A2,A3,A4,A5],C4),
	nth1(D4buf,[D1,D2,D3,D4,D5],4),
	
	nth1(D5buf,[A1,A2,A3,A4,A5],C5),
	nth1(D5buf,[D1,D2,D3,D4,D5],5),

/******************************/

	nth1(F1buf,[A1,A2,A3,A4,A5],B1),
	nth1(F1buf,[F1,F2,F3,F4,F5],1),
	
	nth1(F2buf,[A1,A2,A3,A4,A5],B2),
	nth1(F2buf,[F1,F2,F3,F4,F5],2),
	
	nth1(F3buf,[A1,A2,A3,A4,A5],B3),
	nth1(F3buf,[F1,F2,F3,F4,F5],3),
	
	nth1(F4buf,[A1,A2,A3,A4,A5],B4),
	nth1(F4buf,[F1,F2,F3,F4,F5],4),
	
	nth1(F5buf,[A1,A2,A3,A4,A5],B5),
	nth1(F5buf,[F1,F2,F3,F4,F5],5),

/******************************/

	nth1(E1buf,[C1,C2,C3,C4,C5],B1),
	nth1(E1buf,[E1,E2,E3,E4,E5],1),
		
	nth1(E2buf,[C1,C2,A3,A4,A5],B2),
	nth1(E2buf,[E1,E2,E3,E4,E5],2),
		
	nth1(E3buf,[C1,C2,C3,C4,C5],B3),
	nth1(E3buf,[E1,E2,E3,E4,E5],3),
		
	nth1(E4buf,[C1,C2,C3,C4,C5],B4),
	nth1(E4buf,[E1,E2,E3,E4,E5],4),
	
	nth1(E5buf,[C1,C2,C3,C4,C5],B5),
	nth1(E5buf,[E1,E2,E3,E4,E5],5),

        /*Wypisanie rozwiązania*/
/*-------------------------------------*/	
	write("A = "), writeln(X1),
	write("B = "), writeln(X2),
	write("C = "), writeln(X3),
	write("D = "), writeln(X4),
	write("E = "), writeln(X5),
	write("F = "), writeln(X6),
	!.

