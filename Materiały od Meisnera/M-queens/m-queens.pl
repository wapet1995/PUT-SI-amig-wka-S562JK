:- use_module(library(lists),[member/2]).

mqueens(M,Solution) :-
   findall(sq(A,B),(numlist(1,M,Rows),
                    member(A,Rows),member(B,Rows)),Squares),
   mqueens(M,Squares,[],Solution).

mqueens(M,NotAttacked,PartialSolution,Solution) :-
   ( M == 0 ->
        NotAttacked = [],
        Solution = PartialSolution
     ;
        M1 is M - 1,
        (
           member(sq(M,X),NotAttacked),
           safe(PartialSolution,1,X),
           delete_attacked(NotAttacked,M,X,NotAttacked1)
        ;
           X = none,
           NotAttacked1 = NotAttacked
        ),
        mqueens(M1,NotAttacked1,[X|PartialSolution],Solution)
   ).

safe([],_,_).
safe([X|R],Dist,Y) :-
   ( X == none ->
        true
   ;
     X =\= Y,
     abs(X - Y) =\= Dist
   ),
   Dist1 is Dist + 1,
   safe(R,Dist1,Y).

delete_attacked([],_,_,[]).
delete_attacked([sq(A,B)|R],I,J,Squares) :-
   ( (A =:= I ; B =:= J ; A-B =:= I-J ; A+B =:= I+J) ->
        delete_attacked(R,I,J,Squares)
     ;
        Squares = [sq(A,B)|S],
        delete_attacked(R,I,J,S)
   ).
