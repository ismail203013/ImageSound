SELECT t.artist, t.title, i.genre, i.duration
FROM tracks t 
INNER JOIN info i 
on t.trackId = i.trackId
WHERE i.release_date >= DATEADD(year,-1,GETDATE())
ORDER BY t.artist ASC, t.title ASC;