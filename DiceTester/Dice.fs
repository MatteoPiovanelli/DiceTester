namespace DiceTester

// Probability
// For dice, usually the events we are interested in are not the power set, but only the sample space
// e.g for a d6, we only care for the single results, and not, for example the odd numbers.
// An exception to this could be the d20 for attacks, that will have the set of results that hit,
// and the set of results that crit. Also for saves, we can crit on a 20: the difference with attacks
// is that those may have an extended crit range in some cases.

module Dice =

    type Dice = 
        {Max : int}

        member this.Probability (v:int) =
            let isInRange x =
                match x with
                | 0 -> 0.0
                | x when x <= this.Max -> this.BaseProbability
                | x -> 0.0
            v |> isInRange 
            
        member private this.BaseProbability = 1.0 / (float this.Max)

        member this.Distribution =
            [ for value in 1 .. this.Max do
                yield (value, this.BaseProbability) ]