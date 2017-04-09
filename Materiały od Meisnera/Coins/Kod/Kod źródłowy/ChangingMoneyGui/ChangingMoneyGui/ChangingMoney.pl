:- use_module(library(clpfd)).

change(PRICE,
       [  ZL5,   ZL2,   ZL1,   G50,   G20,   G10,   G05,   G02,   G01],
       [C_ZL5, C_ZL2, C_ZL1, C_G50, C_G20, C_G10, C_G05, C_G02, C_G01]) :-
           Vars = [ZL5, ZL2, ZL1, G50, G20, G10, G05, G02, G01],
           ZL5 in 0..C_ZL5,
           ZL2 in 0..C_ZL2,
           ZL1 in 0..C_ZL1,
           G50 in 0..C_G50,
           G20 in 0..C_G20,
           G10 in 0..C_G10,
           G05 in 0..C_G05,
           G02 in 0..C_G02,
           G01 in 0..C_G01,
           ZL5 * 500 + ZL2 * 200 + ZL1 * 100 + G50 * 50 + G20 * 20 + G10 * 10 + G05 * 5 + G02 * 2 + G01 #= PRICE,
           labeling([min(ZL5 + ZL2 + ZL1 + G50 + G20 + G10 + G05 + G02 + G01)], Vars).
      