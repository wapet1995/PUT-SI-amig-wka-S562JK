%
%  Author: Adam Meissner, 4.02.2010
%

:- use_module(library(clpfd)).

main :-
       Dane = [[austria, [italy,switzerland,germany]],
                [belgium, [france,netherlands,germany,luxemburg]],
                [france, [spain,luxemburg,italy]],
                [germany, [austria,france,luxemburg,netherlands]], 
                [italy, []], 
                [luxemburg, []],
                [netherlands, []],
                [portugal, []],
                [spain, [portugal]], 
                [switzerland, [italy,france,germany,austria]]],
        findall(Kraj,nth1(_,Dane,[Kraj,_]),Kraje),
        length(Kraje,KrajeNo),
        length(KrajKolory,KrajeNo),
        kolorowanie(Dane,Kraje,KrajeNo,KrajKolory),
        write('Kolorowanie'),nl,!,
        ( nth1(KrajInd,Kraje,Kraj1),
          nth1(KrajInd,KrajKolory,KrajKol),
          write(Kraj1),write(':'),write(KrajKol),write(' '),
          fail
          ;
          nl).

kolorowanie(Dane,Kraje,KrajeNo,KrajKolory) :-
        KolorNo in 1..KrajeNo,
        labeling([leftmost],[KolorNo]),
        KrajKolory ins 1 .. KolorNo,
        ogranicz(Dane,Kraje,KrajKolory),
        labeling([ff],KrajKolory).

ogranicz(Dane,Kraje,KrajKolory) :-
         Dane = [[Kraj,Sasiedzi]|DaneR] ->
            nth1(KrajInd,Kraje,Kraj),
            nth1(KrajInd,KrajKolory,KrajKol),
            ogranicz1(Kraje,KrajKol,Sasiedzi,KrajKolory),
            ogranicz(DaneR,Kraje,KrajKolory)
         ;
         true.
         
ogranicz1(Kraje,KrajKol,Sasiedzi,KrajKolory) :-
         Sasiedzi = [Sasiad|SasiedziR] ->
            nth1(SasiadInd,Kraje,Sasiad),
            nth1(SasiadInd,KrajKolory,SasiadKol),
            KrajKol #\= SasiadKol,
            ogranicz1(Kraje,KrajKol,SasiedziR,KrajKolory)
         ;
         true.
