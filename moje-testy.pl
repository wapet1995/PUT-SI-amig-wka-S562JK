:- use_module(library(clpfd)).

zadanie_TEST([A1,A2,A3,A4,A5],
[B1,B2,B3,B4,B5],
[C1,C2,C3,C4,C5],
[D1,D2,D3,D4,D5],
[E1,E2,E3,E4,E5],
[F1,F2,F3,F4,F5]):-
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

 /*zdanie 8*/
D3 = 1,

 /*zdanie 9*/
A5 in 1 \/ 3..5,


 /*zdanie 10*/
E4 = 5.
 






