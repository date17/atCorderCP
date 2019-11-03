# atcoder144b  20min
count = 0
N = gets.to_f
if 1 <= N && N <= 9
   puts "yes"
   count = 1
else
   1.upto(9) do |num|
   num = (N / num.to_f)

    if num == num.to_i && 1 <= num && num <= 9
      puts "yes"
      count = 1
      break
    end
  end
end

if count != 1
  puts "no"
end
