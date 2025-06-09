# IoT 더미데이터 생성 프로그램
# 현재 일로부터 10,000일 전을 시작으로 하루에 데이터 100개씩
# pip install mysql-connector-python 로 설치

import mysql.connector
import random
from datetime import datetime, timedelta

# MySQL 연결 설정
conn = mysql.connector.connect(
    host='localhost',
    database='smarthome',
    user='root',
    password='12345',
)

cursor = conn.cursor()  # db 연결 생성, 커서 생성

# 입력값 파라미터
start_date = datetime(1998, 1, 20)  # 10,000일전 기준일
record_per_day = 100
total_days = 10000

# 입력 쿼리
insert_query = '''
INSERT INTO iot_datas (sensing_dt, loc_id, temp, humid)
VALUES (%s, %s, %s, %s)
'''

batch_size = 1000
batch = []

# 배치리스트 생성
for day in range(total_days):   # 10000일 반복
    date = start_date + timedelta(days=day)
    for i in range(record_per_day): # 100번 반복
        timestamp = date + timedelta(minutes=15 * i)
        temp = round(random.uniform(19.0, 28.0), 1)     # 19~28도 사이 온도 랜덤으로, 소수점 첫번째 반올림
        humid = round(random.uniform(30.0, 60.0), 2)    # 30~60% 사이 습도 랜덤으로, 소수점 첫번째 반올림
        batch.append((timestamp, 'DINNING', temp, humid))

        if len(batch) >= batch_size:
            cursor.executemany(insert_query, batch)     # 한꺼번에 배치사이즈만큼 데이터 삽입
            conn.commit()
            batch.clear()
    
    print(f'100번 완료 : {day}')

# 남은 배치리스트가 있으면
if batch:
    cursor.executemany(insert_query, batch)
    conn.commit()
    batch.clear()   # 다 끝났기 때문에 굳이 클리어 안해줘도 됨

# 리소스 해제
cursor.close()
conn.close()
print('더미데이터 생성 완료')