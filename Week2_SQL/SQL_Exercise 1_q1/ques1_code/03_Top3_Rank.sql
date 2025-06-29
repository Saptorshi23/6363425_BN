SELECT *
FROM (
    SELECT *,
           RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS PriceRank
    FROM Products
) AS Ranked
WHERE PriceRank <= 3;
