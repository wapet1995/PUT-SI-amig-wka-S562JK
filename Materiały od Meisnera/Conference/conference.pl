%
%  Author: Adam Meissner, 4.02.2010
%

:- use_module(library(clpfd)).

main :-
  conference(Plan),
  write(Plan),nl.

conference(Plan) :-
   Data = [nbSessions(11),
           nbParSessions(3),
           constraints(
               [before(4,11),
                before(5,10),
                before(6,11),
                disjoint(1, [2,3,5,7,8,10]),
                disjoint(2, [3,4,7,8,9,11]),
                disjoint(3, [5,6,8]),
                disjoint(4, [6,8,10]),
                disjoint(6, [7,10]),
                disjoint(7, [8,9]),
                disjoint(8, [10])])],
   member(nbSessions(NbSessions),Data),
   member(nbParSessions(NbParSessions),Data),
   member(constraints(Constraints),Data),
   MinNbSlots is NbSessions // NbParSessions,
   NbSlots in MinNbSlots .. NbSessions,
   labeling([leftmost],[NbSlots]),
   length(Plan,NbSessions),
   Plan ins 1 .. NbSlots,
   for_at_most(1,NbSlots,NbParSessions,Plan),
   maplist(constraint(Plan),Constraints,_),
   labeling([ff],Plan).

for_at_most(Slot,NbSlots,NbParSessions,Plan) :-
  Slot =< NbSlots ->
     at_most(NbParSessions,Plan,Slot),
     Slot1 is Slot + 1,
     for_at_most(Slot1,NbSlots,NbParSessions,Plan)
  ;
  true.

at_most(D, Dv, I) :-
   maplist(eq_b(I), Dv, Bs),
   sum(Bs, #=<, D).

eq_b(X, Y, B) :- X #= Y #<==> B.

constraint(Plan,before(X,Y),_) :-
   nth1(X,Plan,Px),
   nth1(Y,Plan,Py),
   Px #< Py.
constraint(Plan,disjoint(X,Ys),_) :-
   maplist(disjoint(Plan,X),Ys,_).

disjoint(Plan,X,Y,_) :-
   nth1(X,Plan,Px),
   nth1(Y,Plan,Py),
   Px #\= Py.   
