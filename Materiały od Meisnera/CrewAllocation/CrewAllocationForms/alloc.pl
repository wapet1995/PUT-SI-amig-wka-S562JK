:- module(crewProb, [test/0, matchTeams/3]).
:- use_module(library(clpfd)).
		

matchTeams(Teams, Requires, Crew) :-
	length(Requires, NumFlights),
	length(Crew, CrewCount),
				   
	splitRequires(Requires, ReqCrewCount, FlightsReqs),
	teamsMatrix(Teams, NumFlights, CrewCount, ReqCrewCount),
	checkFlightsReqs(Teams, FlightsReqs, Crew),
	
	flattenMatrix(Teams, TeamsList),
	labeling([ff,bisect,down], TeamsList)
.

splitRequires([], [], []).
splitRequires([[RE|RL]|RestCrew], [RE|RestEmps], [RL|RestLangs]) :-
	splitRequires(RestCrew, RestEmps, RestLangs).

teamsMatrix([Team], 1, CrewCount, [ReqCrewCount]) :-
	length(Team, CrewCount),
	Team ins 0..1,
	sum(Team, #=, ReqCrewCount).
teamsMatrix([Team|RestTeams], Flights, CrewCount, [ReqCrewCount|RestReqs]) :-
	teamsMatrix(RestTeams, RestFlights, CrewCount, RestReqs),
	Flights #= RestFlights+1,
	length(Team, CrewCount),
	Team ins 0..1,
	sum(Team, #=, ReqCrewCount),
	checkBreaks([Team|RestTeams]).

checkFlightsReqs([], [], _).
checkFlightsReqs([Team|RestTeams], [FlightsReq|RestReqs], Crew) :-
	checkEmployees(Team, TeamAttrbts, Crew),
	checkRelation(TeamAttrbts, FlightsReq, #>=),
	checkFlightsReqs(RestTeams, RestReqs, Crew).

checkEmployees([], [0,0,0,0,0], _).
checkEmployees([0|RT], TeamAttrbts, [_|Crew]) :-
	checkEmployees(RT, TeamAttrbts, Crew).
checkEmployees([1|RT], TeamAttrbts, [EAttr|Crew]) :-
	checkEmployees(RT, RAttr, Crew),
	addVector(RAttr, EAttr, TeamAttrbts).


checkBreaks([A,B]) :-
	addVector(A,B,AB),
	AB ins 0..1.
checkBreaks([A,B,C|R]) :-
	addVector(A,B,AB),
	AB ins 0..1,
	addVector(A,C,AC),
	AC ins 0..1.

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

test :-
	Crew =
	[[1,0,0,0,1],   % Tom     = 1
	 [1,0,0,0,0],   % David   = 2
	 [1,0,0,0,1],   % Jeremy  = 3
	 [1,0,0,0,0],   % Ron     = 4
	 [1,0,0,1,0],   % Joe     = 5
	 [1,0,1,1,0],   % Bill    = 6
	 [1,0,0,1,0],   % Fred    = 7
	 [1,0,0,0,0],   % Bob     = 8
	 [1,0,0,1,1],   % Mario   = 9
	 [1,0,0,0,0],   % Ed      = 10

	 [0,1,0,0,0],   % Carol   = 11
	 [0,1,0,0,0],   % Janet   = 12
	 [0,1,0,0,0],   % Tracy   = 13
	 [0,1,0,1,1],   % Marilyn = 14
	 [0,1,0,0,0],   % Carolyn = 15
	 [0,1,0,0,0],   % Cathy   = 16
	 [0,1,1,1,1],   % Inez    = 17
	 [0,1,1,0,0],   % Jean    = 18
	 [0,1,0,1,1],   % Heather = 19
	 [0,1,1,0,0]    % Juliet  = 20
	],
	
	CrewNames = [tom, david, jeremy, ron, joe,
				 bill, fred, bob, mario, ed,
				 carol, janet, tracy, marylin, carolyn,
				 cathy, inez, jean, heather, juliet],
	
	Requires = [[4, 1,1,1,1,1],
				[5, 1,1,1,1,1], 
				[5, 1,1,1,1,1],
				[6, 2,2,1,1,1],
				[7, 3,3,1,1,1],
				[4, 1,1,1,1,1],
				[5, 1,1,1,1,1],
				[6, 1,1,1,1,1],
				[6, 2,2,1,1,1],
				[7, 3,3,1,1,1]
			   ],

	matchTeams(Teams, Requires, Crew),
	 
	nl,
	printTeams(Teams, CrewNames),
	nl
.

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

checkRelation([], [], _).
checkRelation([A|AR], [B|BR], Rel) :-
	call(Rel,A,B),
	checkRelation(AR, BR, Rel).

addVector([], [], []).
addVector([A|RA], [B|RB], [C|Res]) :-
	addVector(RA,RB,Res),
	C #= A+B.

flattenMatrix([T], T).
flattenMatrix([T|RT], TL) :-
	flattenMatrix(RT, RTL),
	append(T, RTL, TL).

printTeams(Teams, CrewNames) :-
	printTeams(Teams, 1, CrewNames).
printTeams([T], Nr, Names) :-
	format('Lot ~a: ', Nr),
	printTeam(T, Names).
printTeams([T|R], Nr, Names) :-
	format('Lot ~a: ', Nr),
	printTeam(T, Names),
	Nr2 is Nr+1,
	printTeams(R, Nr2, Names).

printTeam([], _) :-	nl.
printTeam([0|R], [_|RNames]) :-
	printTeam(R, RNames).
printTeam([1|R], [Name|RNames]) :-
	format('~w ', Name),
	printTeam(R, RNames).
	
