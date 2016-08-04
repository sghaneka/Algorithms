function Next-Triangle-Num([int]$priorTriangularNumber, [int]$currentIndex){
    return $priorTriangularNumber + $currentIndex
}

function FindFactors([int] $num){
    $fact = 0

    for($i = 1; $i -le [math]::Sqrt($num); $i++){
        if ($num % $i -eq 0){
            $fact++
        }
    }

    

    return $fact
}

function FindDivisibleTriangularNumber([int] $divisors){
    $currTriNum = 1
    $currentIndex = 1

    do
    {
        
        $factors = FindFactors $currTriNum
        Write-Host "Checking: $currTriNum Factors: $factors"
        if ($factors -gt $divisors){
            break
        }
        $currentIndex++
        $currTriNum = Next-Triangle-Num $currTriNum $currentIndex

    } while ($true)

    return $currTriNum
}

FindDivisibleTriangularNumber 500