namespace DiceTester

type Dist<'T> when 'T : comparison = Map<'T, float>

module Distribution =
