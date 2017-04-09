change(PRICE,
       [  ZL5,   ZL2,   ZL1,   G50,   G20,   G10,   G05,   G02,   G01],
       [C_ZL5, C_ZL2, C_ZL1, C_G50, C_G20, C_G10, C_G05, C_G02, C_G01]) :-
    divider(PRICE, 500, X1), member(ZL5, X1), ZL5 =< C_ZL5,   /* piêcioz³otówki */
    divider(PRICE, 200, X2), member(ZL2, X2), ZL2 =< C_ZL2,   /* dwuz³otówki */
    divider(PRICE, 100, X3), member(ZL1, X3), ZL1 =< C_ZL1,   /* z³otkówki */
    divider(PRICE, 050, X4), member(G50, X4), G50 =< C_G50,   /* piêædziesiêciogroszówki */
    divider(PRICE, 020, X5), member(G20, X5), G20 =< C_G20,   /* dwudziestogroszówki */
    divider(PRICE, 010, X6), member(G10, X6), G10 =< C_G10,   /* dziesiêciogroszówki */
    divider(PRICE, 050, X7), member(G05, X7), G05 =< C_G05,   /* piêciogroszówki */
    divider(PRICE, 020, X8), member(G02, X8), G02 =< C_G02,   /* dwugroszówki */
    SUM is ZL5 * 500 + ZL2 * 200 + ZL1 * 100 + G50 * 50 + G20 * 20 + G10 * 10 + G05 * 5 + G02 * 2,
    SUM =< PRICE,
    G01 is PRICE - SUM, G01 =< C_G01.
    
divider(PRICE, VALUE, X2) :- divide(PRICE, VALUE, X1), reverse(X1, X2).

divide(PRICE, VALUE, [0]) :- VALUE > PRICE.
divide(PRICE, VALUE, [0, 1]) :- VALUE =:= PRICE.
divide(PRICE, VALUE, X) :- VALUE < PRICE, integers(PRICE, VALUE, X1), append([0], X1, X).

integers(PRICE, VALUE, [1|X]) :- integers(PRICE, VALUE, 2, X).
integers(PRICE, VALUE, I, [I|X]) :- I * VALUE =< PRICE, I1 is I + 1, integers(PRICE, VALUE, I1, X).
integers(PRICE, VALUE, I, []) :- I * VALUE > PRICE.


/*

change(51, [ZL5, ZL2, ZL1, G50, G20, G10, G05, G02, G01], [1, 2, 3, 2, 3, 4, 2, 6, 5]).

*/
