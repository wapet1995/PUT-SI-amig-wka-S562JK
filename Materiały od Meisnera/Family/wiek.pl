:- use_module(library(clpfd)).

wiek_(Maria, Clara) :-
    Maria = [BM1, BM2, BM3, GM1, GM2, GM3],
	Clara = [BC1, BC2, BC3, GC1, GC2, GC3],
	Maria ins 0..9,
	Clara ins 0..9,
	GC3 = 0,
	all_different(Maria),
	all_different(Clara),
	(
	(GM1 #< BM1), (GM1 #< BM2), (GM1 #< BM3);
	(GM2 #< BM1), (GM2 #< BM2), (GM2 #< BM3);
	(GM3 #< BM1), (GM3 #< BM2), (GM3 #< BM3)
	),
	BM1 + BM2 + BM3 #= GM1 + GM2 + GM3,
	BC1 + BC2 + BC3 #= GC1 + GC2 + GC3,
	BM1*BM1 + BM2*BM2 + BM3*BM3 #= GM1*GM1 + GM2*GM2 + GM3*GM3,
	BC1*BC1 + BC2*BC2 + BC3*BC3 #= GC1*GC1 + GC2*GC2 + GC3*GC3,
	BM1 + BM2 + BM3 + GM1 + GM2 + GM3 + BC1 + BC2 + BC3 + GC1 + GC2 + GC3 #= 60.



wiek :-
    wiek_(Maria, Clara), label(Maria), label(Clara),
    write('Dzieci Marii, kolejno, Ch, Ch, Ch, D, D, D:'),
    write('\n'),
    write(Maria),
    write('\n\n'),
    write('Dzieci Klary, kolejno, Ch, Ch, Ch, D, D, D:'),
    write('\n'),
    write(Clara),
    true;
    fail,
    !.
