a = ARGV[0].to_i
b = ARGV[1].to_i

value = a - (2 * b)
if value <= 0
  puts 0
else
  puts value
end
