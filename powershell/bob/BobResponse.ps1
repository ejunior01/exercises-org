Function Get-BobResponse() {
    <#
    .SYNOPSIS
    Bob is a lackadaisical teenager. In conversation, his responses are very limited.
    
    .DESCRIPTION
    Bob is a lackadaisical teenager. In conversation, his responses are very limited.

    Bob answers 'Sure.' if you ask him a question.

    He answers 'Whoa, chill out!' if you yell at him.

    He answers 'Calm down, I know what I'm doing!' if you yell a question at him.

    He says 'Fine. Be that way!' if you address him without actually saying
    anything.

    He answers 'Whatever.' to anything else.
    
    .PARAMETER HeyBob
    The sentence you say to Bob.
    
    .EXAMPLE
    Get-BobResponse -HeyBob "Hi Bob"
    #>
    [CmdletBinding()]
    Param(
        [string]$HeyBob
    )

    $CountLetters = ($HeyBob.ToCharArray() | ForEach-Object { $_ -cmatch "[A-Za-z]" } | Where-Object { $_ } | Measure-Object).Count

    $IsQuestion = $HeyBob.Trim().EndsWith("?")
    $IsScreen = $CountLetters -gt 0 -and $CountLetters -eq ($HeyBob.ToCharArray() | ForEach-Object { $_ -cmatch "[A-Z]" } | Where-Object { $_ } | Measure-Object).Count
    
    if ($IsQuestion -and $IsScreen) {
        return "Calm down, I know what I'm doing!"
    }

    if ($IsQuestion) {
        return "Sure."
    }

    if ($IsScreen) {
        return "Whoa, chill out!"
    }

    if($HeyBob.Trim().Length -eq 0 ) {
        return "Fine. Be that way!"
    }

    return "Whatever."
}
