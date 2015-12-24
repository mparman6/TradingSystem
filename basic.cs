Breakout Strategy
- If the 50 day MA is above the 100 day MA,
o If today’s close is higher or equal to the highest close in the past 50 days, buy long. 
- If the 50 day MA is below the 100 day MA, 
o If today’s close is below or equal to the lowest close for the past 50 days, sell short. 
Position Sizing
- Based on ATR formula
- Risk factor of .2%
- Contracts = (.002 * Equity) / (ATR * pointValue)
- portfolioEquity = current $ value of portfolio
- perTrade = .002 * portfolioEquity 
- trueLow = today’s low or yesterday’s low (whichever is lower)
- trueHigh = today’s high or yesterday’s high (whichever is higher) 
- trueRange = trueHigh – trueLow
- averageTrueRange = trueRangeDollars of last x days (average)
- trueRangeDollars = trueRange * pointValue of contract
Stop
- ATR Trailing Stop =
o  true range (daily trading range, or how many dollars the instrument moved in a particular day).
o Average true range (ATR) is average of true range over a set number of days, 100 days for example.
- Long position is stopped out when it has moved three ATR units down from its highest closing price since the position was open.
- Short position is closed when it has moved three ATR units up from its lowest closing price since the position was opened.
