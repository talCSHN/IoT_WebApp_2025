-- CTE(Common Table Expression) 작업
-- 10만건을 세션으로 만들겠다
SET SESSION cte_max_recursion_depth = 100000;

-- 더미 데이터 삽입 쿼리
INSERT INTO News (Writer, Title, Description, PostDate, ReadCount)
WITH RECURSIVE cte (n) AS
(
SELECT 1
UNION ALL
SELECT n + 1 FROM cte WHERE n < 100000 -- 생성하고 싶은 더미 데이터의 개수
)
SELECT
  '관리자' AS Writer,
  CONCAT('뉴스제목입니다_', LPAD(n, 6, '0')) AS Title,
  CONCAT('뉴스내용입니다_', LPAD(n, 6, '0')) AS Description,
  TIMESTAMP(DATE_SUB(NOW(), INTERVAL FLOOR(RAND() * 3650) DAY) + INTERVAL FLOOR(RAND() * 86400) SECOND) AS PostDate
  , 0 AS ReadCount
FROM cte;

-- 잘 생성됐는 지 확인
SELECT COUNT(*) FROM News;