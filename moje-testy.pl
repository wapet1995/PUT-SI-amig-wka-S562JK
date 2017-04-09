:- use_module(library(clpfd)).

zadanie_TEST([A1,A2,A3,A4,A5],
[B1,B2,B3,B4,B5],
[C1,C2,C3,C4,C5],
[D1,D2,D3,D4,D5],
[E1,E2,E3,E4,E5],
[F1,F2,F3,F4,F5]):-

A1 in 1..5,
A2 in 1..5,
A3 in 1..5,
A4 in 1..5,
A5 in 1..5,

B1 in 1..5,
B2 in 1..5,
B3 in 1..5,
B4 in 1..5,
B5 in 1..5,

C1 in 1..5,
C2 in 1..5,
C3 in 1..5,
C4 in 1..5,
C5 in 1..5,

D1 in 1..5,
D2 in 1..5,
D3 in 1..5,
D4 in 1..5,
D5 in 1..5,

E1 in 1..5,
E2 in 1..5,
E3 in 1..5,
E4 in 1..5,
E5 in 1..5,

F1 in 1..5,
F2 in 1..5,
F3 in 1..5,
F4 in 1..5,
F5 in 1..5,

/*ZDANIE1*/
 A1 in 1..2 \/ 4..5,
 D1 in 1..2 \/  4..5,
 F1 in 1..2 \/ 3..4,
 B2  in 1..2 \/ 4..5,
 C3 in 1..2 \/  4..5,
 E2 in 1..2 \/  4..5,
 E5 in 1..2 \/  4..5,
 B5 in 1..2 \/ 4..5,


/*Zdanie2  E1 in 1..2 \/ 4..5  /\   E1 in 1..3 \/ 5 */
E1 in 1..2 \/ 4..5 #\/ E1 in 1..3 \/5,
/*Zdanie 3*/
 B5 in 4..5,

 /*zdanie 4*/
E5 #< 5,
B5 #< 5, 

 /*zdanie 5*/
A2 #< 5,
F2 in 1 \/ 3..5,

 /*zdanie 6*/
A4 #> 1,
D4 in 1..2 \/ 4..5,

 /*zdanie 7 nie wiem jak*/
A1#=F2,
A2#=F1,
A1#=4 #\/ A2#=4,
 /*zdanie 8*/
D3 = 1,

 /*zdanie 9*/
A5 in 1 \/ 3..5,


 /*zdanie 10*/
E4 = 5,
 
/*rozgraniczenia podstawowe */
A1#\=A2,
A1#\=A3,
A1#\=A4,
A1#\=A5,
A2#\=A3,
A2#\=A4,
A2#\=A5,
A3#\=A4,
A3#\=A5,
A4#\=A5,

B1#\=B2,
B1#\=B3,
B1#\=B4,
B1#\=B5,
B2#\=B3,
B2#\=B4,
B2#\=B5,
B3#\=B4,
B3#\=B5,
B4#\=B5,

C1#\=C2,
C1#\=C3,
C1#\=C4,
C1#\=C5,
C2#\=C3,
C2#\=C4,
C2#\=C5,
C3#\=C4,
C3#\=C5,
C4#\=C5,

D1#\=D2,
D1#\=D3,
D1#\=D4,
D1#\=D5,
D2#\=D3,
D2#\=D4,
D2#\=D5,
D3#\=D4,
D3#\=D5,
D4#\=D5,

E1#\=E2,
E1#\=E3,
E1#\=E4,
E1#\=E5,
E2#\=E3,
E2#\=E4,
E2#\=E5,
E3#\=E4,
E3#\=E5,
E4#\=E5,

F1#\=F2,
F1#\=F3,
F1#\=F4,
F1#\=F5,
F2#\=F3,
F2#\=F4,
F2#\=F5,
F3#\=F4,
F3#\=F5,
F4#\=F5.








