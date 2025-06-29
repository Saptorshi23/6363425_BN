SELECT *
FROM (
    SELECT *,
           DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DensePriceRank
    FROM Products
) AS Ranked
WHERE DensePriceRank <= 3;
