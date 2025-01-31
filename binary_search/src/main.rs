use std::cmp::Ordering;

fn main() {}

#[derive(PartialEq, Debug)]
struct Output {
    index: usize,
    steps: usize,
}

fn run(input: Vec<i32>, target: i32) -> Option<Output> {
    let mut low: usize = 0;
    let mut high: usize = input.len() - 1;
    let mut steps: usize = 0;

    while low <= high {
        steps += 1;

        let mid: usize = (low + high) / 2;

        let found = input[mid];

        match found.cmp(&target) {
            Ordering::Equal => {
                return Some(Output { index: mid, steps });
            }
            Ordering::Less => {
                low = mid + 1;
            }
            Ordering::Greater => {
                high = mid - 1;
            }
        }
    }

    None
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn run_should_take_seven_steps() {
        let data = fill(1, 129);
        let answer = Output {
            index: 48,
            steps: 7,
        };

        assert_eq!(run(data, 49), Some(answer));
    }

    #[test]
    fn run_should_take_three_steps() {
        let data = fill(1, 9);
        let answer = Output {
            index: 0,
            steps: 3,
        };

        assert_eq!(run(data, 1), Some(answer));
    }

    #[test]
    fn run_should_return_none() {
        let data = fill(1, 9);

        assert!(run(data, 10).is_none());
    }

    fn fill(start: i32, end: i32) -> Vec<i32> {
        let data: Vec<i32> = (start..end).collect();

        data
    }
}
